const mongoose = require('mongoose');
mongoose.set('strictQuery', true);

mongoose.connect('mongodb://127.0.0.1:27017/product-apis');
const db = mongoose.connection;
db.on('error', (err) => {
    console.error("Failed to connect to database: " + err.message);
})

db.once('open', () => {
    console.log("Connected to the database.");
});