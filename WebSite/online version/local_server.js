const http = require('http');
const fs = require('fs');
const path = require('path');

// إعدادات السيرفر
const server = http.createServer((req, res) => {
    let filePath = path.join(__dirname, req.url === '/' ? 'index.html' : req.url);
    let extname = path.extname(filePath);
    let contentType = 'text/html';

    // تحديد نوع المحتوى بناءً على امتداد الملف
    if (extname === '.js') {
        contentType = 'application/javascript';
    } else if (extname === '.css') {
        contentType = 'text/css';
    } else if (extname === '.json') {
        contentType = 'application/json';
    }

    fs.readFile(filePath, (err, content) => {
        if (err) {
            res.writeHead(500);
            res.end('Server Error');
        } else {
            res.writeHead(200, { 'Content-Type': contentType });
            res.end(content);
        }
    });
});

// تشغيل السيرفر على البورت 8080
server.listen(8080, () => {
    console.log('Server running at http://localhost:8080/');
});
