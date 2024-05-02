var starWarsCursor = document.querySelector('.star-wars-cursor');
var trail = document.querySelector('.trail');

document.addEventListener('mousemove', function (e) {
    var x = e.clientX;
    var y = e.clientY;
    starWarsCursor.style.left = x + 'px';
    starWarsCursor.style.top = y + window.scrollY + 'px';

   
    trail.style.left = x - 10 + 'px'; 
    trail.style.top = y + window.scrollY - 10 + 'px'; 
    trail.style.opacity = 1; 
});

setInterval(function () {
    trail.style.opacity = 0;
}, 100);