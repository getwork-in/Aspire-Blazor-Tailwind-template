function setTheme(theme) {
    const root = document.documentElement;
    root.classList.remove('light', 'dark');

    if (theme === 'system') {
        const systemTheme = window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light';
        root.classList.add(systemTheme);
    } else {
        root.classList.add(theme);
    }
}

document.addEventListener('DOMContentLoaded', function () {
    const savedTheme = localStorage.getItem('blazorapp7-ui-theme') || 'system';
    setTheme(savedTheme);
});

// Set theme on navigation events to retain consistency
window.addEventListener('blazor:navigation', function () {
    const savedTheme = localStorage.getItem('blazorapp7-ui-theme') || 'system';
    setTheme(savedTheme);
});