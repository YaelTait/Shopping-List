const db = require('../config/db');

const getAllCategories = () => {
  return new Promise((resolve, reject) => {
    db.query('SELECT * FROM categories', (error, results) => {
      if (error) {
        reject(error);
      } else {
        resolve(results);
      }
    });
  });
};

module.exports = {
  getAllCategories,
};
