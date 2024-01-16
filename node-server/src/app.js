// // app.js
const express = require('express');
require('dotenv').config()

const cors = require('cors');

const app = express(); 
app.use(cors());const categoriesRoutes = require('./routes/categories');

// Middleware to parse JSON bodies
app.use(express.json());

// Use categories routes
app.use('/api', categoriesRoutes);

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}`);
});
