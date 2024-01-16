const express = require('express');
const router = express.Router();
const categoriesController = require('../controllers/category');

router.get('/categories', categoriesController.getAllCategories);

module.exports = router;
