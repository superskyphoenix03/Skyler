window.initializeKeyListeners = function (dotNetHelper) {
    document.addEventListener("keydown", function (event) {
        switch (event.key) {
            case "ArrowUp":
                dotNetHelper.invokeMethodAsync("MoveCharacter", "up");
                break;
            case "ArrowDown":
                dotNetHelper.invokeMethodAsync("MoveCharacter", "down");
                break;
            case "ArrowLeft":
                dotNetHelper.invokeMethodAsync("MoveCharacter", "left");
                break;
            case "ArrowRight":
                dotNetHelper.invokeMethodAsync("MoveCharacter", "right");
                break;
        }
    });
};
