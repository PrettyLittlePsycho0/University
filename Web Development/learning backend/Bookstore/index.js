const express = require('express');
const port = 6969;

const bookTemplate = {
    bookID: 'number',
    title: 'string',
    edition: 'number',
    author: 'string',
    price: 'number'
};

function createBook(data, id) {
    const newBook = {};
    for (let key in bookTemplate) {
        if (key === 'bookID') {
            newBook.bookID = id;
        } else {
            newBook[key] = data[key] ?? null;
        }
    }
    return newBook;
}

const app = express();
app.use(express.json());

let books = [];
let nextBookId = 1;

// Add book
app.post("/books", (req, res) => {
    const newBook = createBook(req.body, nextBookId++);
    books.push(newBook);
    res.status(201).json(newBook);
});

// Read book by ID
app.get("/books/:id", (req, res) => {
    const bookId = parseInt(req.params.id);
    const book = books.find(b => b.bookID === bookId);
    if (book) res.json(book);
    else res.status(404).send("Book not found");
});

// ✅ Update book
app.patch("/books/:id", (req, res) => {
    const bookId = parseInt(req.params.id);
    const book = books.find(b => b.bookID === bookId);
    if (!book) return res.status(404).send("Book not found");

    for (let key in req.body) {
        if (bookTemplate.hasOwnProperty(key) && key !== 'bookID') {
            book[key] = req.body[key];
        }
    }

    res.json(book);
});

// Delete book
app.delete("/books/:id", (req, res) => {
    const bookId = parseInt(req.params.id);
    const index = books.findIndex(b => b.bookID === bookId);

    if (index !== -1) {
        const deleted = books.splice(index, 1)[0];
        res.json(deleted);
        nextBookId--;
    } else {
        res.status(404).send("Book not found");
    }
});

// List all books
app.get("/books", (req, res) => {
    res.status(200).json(books);
});

app.listen(port, () => {
    console.log(`Server is running at port: ${port}`);
});
