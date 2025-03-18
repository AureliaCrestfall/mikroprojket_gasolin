const hamburger = document.getElementById('hamburger');
const navbar = document.getElementById('navbar');
const overlay = document.getElementById('overlay');
const bandmedlemmer = document.getElementById('bandmedlemmer');

// Function to open the navbar
function openNavbar() {
    navbar.style.left = '0px';
    overlay.style.display = 'block';
}

// Function to close the navbar
function closeNavbar() {
    navbar.style.left = '-250px';
    overlay.style.display = 'none';
}

// Function to toggle the sub-navbar
function toggleSubNavbar(event) {
    event.stopPropagation(); // Prevent click event from propagating to parent elements
    bandmedlemmer.classList.toggle('open');
}

// Open/Close navbar on hamburger click
hamburger.addEventListener('click', () => {
    if (navbar.style.left === '0px') {
        closeNavbar();
    } else {
        openNavbar();
    }
});

// Close navbar when clicking outside (on the overlay)
overlay.addEventListener('click', closeNavbar);

// Toggle sub-navbar when clicking "Bandmedlemmer"
bandmedlemmer.addEventListener('click', toggleSubNavbar);
