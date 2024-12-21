function readFile() {
    const filePath = '../data/latest update.txt';
    
    fetch(filePath)
        .then(response => response.text())
        .then(data => {
            data = data.split('\n');
            document.getElementById('latest-news-title').innerHTML = data[0];
            document.getElementById('latest-news-content').innerHTML = data[1];
            document.getElementById('latest-news-date').innerHTML = data[2];
        })
        .catch(err => {
            console.error('Error reading file:', err);
        });
}

window.onload = () => {
    readFile();
};
