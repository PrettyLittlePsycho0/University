const express = require('express');
const port = 6996;
const app = express();

let teachers = [];

function validateAndParseInput(template, requiredFields, inputData) {
    const cleaned = {};
    const errors = [];

    for (let key in template) {
        const rawValue = inputData[key];

        // Required check
        if (requiredFields.includes(key) && (rawValue === undefined || rawValue === null || rawValue === '')) {
            errors.push(`Missing required field: "${key}".`);
            break;
        }

        if (rawValue === undefined || rawValue === null || rawValue === '') {
            cleaned[key] = null;
            continue;
        }

        // Type parsing
        switch (template[key]) {
            case 'number':
                const num = Number(rawValue);
                if (isNaN(num)) {
                    errors.push(`Field "${key}" must be a valid number.`);
                } else {
                    cleaned[key] = num;
                }
                break;
            case 'string':
                cleaned[key] = String(rawValue).trim();
                break;
            case 'boolean':
                cleaned[key] = rawValue === 'true' || rawValue === true;
                break;
            default:
                cleaned[key] = rawValue;
        }
    }

    if (errors.length > 0) {
        return { valid: false, errors };
    } else {
        return { valid: true, data: cleaned };
    }
}

app.use(express.json());

const teacherTemplate = {
    CNIC: 'string',
    name: 'string',
    age: 'number',
    phone: 'string',
    city: 'string'
};

const requiredFields = ['CNIC', 'name'];

// Create
app.post('/teacher/add', (req, res) => {
    const result = validateAndParseInput(teacherTemplate, requiredFields, req.body);

    if (!result.valid) {
        return res.status(400).json({ errors: result.errors });
    }

    const newTeacher = result.data;

    // Prevent duplicate CNIC
    const exists = teachers.find(t => t.CNIC === newTeacher.CNIC);
    if (exists) {
        return res.status(409).json({ error: 'Teacher with this CNIC already exists.' });
    }

    teachers.push(newTeacher);
    res.status(201).json(newTeacher);
});

// Update (by CNIC)
const updateRequiredFields = ['CNIC']; // CNIC required to identify which teacher to update
app.patch('/teacher/update', (req, res) => {
    const result = validateAndParseInput(teacherTemplate, updateRequiredFields, req.body);

    if (!result.valid) {
        return res.status(400).json({ errors: result.errors });
    }

    const updated = result.data;
    const index = teachers.findIndex(t => t.CNIC === updated.CNIC);

    if (index === -1) {
        return res.status(404).json({ error: 'Teacher not found.' });
    }

    // Merge fields into existing teacher
    teachers[index] = { ...teachers[index], ...updated };
    res.status(200).json(teachers[index]);
});

// Get all
app.get('/teacher/getall', (req, res) => {
    res.status(200).json(teachers);
});

// Get by CNIC
app.get('/teacher/:cnic', (req, res) => {
    const cnic = req.params.cnic;
    const teacher = teachers.find(t => t.CNIC === cnic);

    if (!teacher) {
        return res.status(404).json({ error: 'Teacher not found.' });
    }

    res.status(200).json(teacher);
});

// Delete by CNIC
app.delete('/teacher/:cnic', (req, res) => {
    const cnic = req.params.cnic;
    const index = teachers.findIndex(t => t.CNIC === cnic);

    if (index === -1) {
        return res.status(404).json({ error: 'Teacher not found.' });
    }

    const removed = teachers.splice(index, 1)[0];
    res.status(200).json({ message: 'Teacher deleted successfully.', removed });
});

// Start server
app.listen(port, () => {
    console.log(`Server started at port: ${port}`);
});
