window.addEventListener("DOMContentLoaded", function (e) {
    const movieButtons = document.querySelectorAll("button[data-movie]");
    movieButtons.forEach(function (button) {
        button.addEventListener("click", function (e) {
            const button = e.currentTarget;
            let id = button.getAttribute("data-movie");

            localStorage.setItem("movie", JSON.stringify(id));

            const url = window.location.href.replace("LandingPage", "DetailPage");
            window.location.href = url;
            naviga
        });
    });
});