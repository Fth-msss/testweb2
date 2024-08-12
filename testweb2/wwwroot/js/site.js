// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {
    let count = 0;
    $(document).on('click', '#clickButton', function () {
        count++;
        $('#clickCount').text(count);
    });
});

$(function () {
    $(document).on('click', '#processButton', function () {
        const userInput = document.getElementById('userInput').value;
        const processedOutput = userInput + 'i have no idea why this isnt working'; // Simple example of processing
        $('#outputText').text(processedOutput);
    });
});