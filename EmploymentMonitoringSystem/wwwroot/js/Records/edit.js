function openTabPage(name, element, color) {
    let tabcontents;
    let tablinks;

    // Hide all elements with class="tabcontent" by default
    tabcontents = document.getElementsByClassName("tabcontent");
    for (let i = 0; i < tabcontents.length; i++) {
        tabcontents[i].style.display = "none";
    }

    // Remove the background color of all tablinks/buttons
    tablinks = document.getElementsByClassName("tablink");
    for (let i = 0; i < tablinks.length; i++) {
        tablinks[i].style.backgroundColor = "";
        tablinks[i].style.color = "white";
    }

    // Show the specific tab content
    document.getElementById(name).style.display = "block";

    // Add the specific color to the button used to open the tab content
    element.style.backgroundColor = color;
    element.style.color = "black";
}

// Get the element with id="defaultOpen" and click on it
document.getElementById("defaultTab").click();