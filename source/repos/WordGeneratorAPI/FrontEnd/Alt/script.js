function submitScore() {
    const scoreData = {
        UserName: "Player1", // Replace with the actual player name if available
        Points: wordCoins,
        DateAchieved: new Date().toISOString()
    };

    fetch(scoreApiUrl, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(scoreData)
    })
    .then(response => {
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        return response.json();
    })
    .then(data => {
        console.log("Score submitted successfully:", data);
    })
    .catch(error => {
        console.error("Failed to submit score:", error);
    });
}

guessButton.addEventListener("click", () => {
    const guess = guessInput.value.toLowerCase();
    guessInput.value = "";

    if (guess && !guessedLetters.includes(guess)) {
        guessedLetters.push(guess);
        if (!selectedWord.includes(guess)) {
            hp -= 10;
            timer -= 5; // Deduct time for wrong guess
            hpElement.innerHTML = `HP: ${hp}`;
            timerElement.innerHTML = `Time: ${timer}`;
        }
        updateWordDisplay();
        checkGameStatus();
    }
});

document.getElementById("continue").addEventListener("click", () => {
    hideShop();
    prepareNextWord();
});

tryAgainButton.addEventListener("click", () => {
    hp = maxHp;
    wordCoins = 0;
    difficultyLevel = "common";
    completedWords = 0;
    guessedLetters = [];
    lives = 3;
    guessButton.disabled = false;
    tryAgainButton.style.display = "none";
    messageElement.innerHTML = "";
    hpElement.innerHTML = `HP: ${hp}`;
    livesElement.innerHTML = `Lives: ${lives}`;
    coinsElement.innerHTML = `Coins: ${wordCoins}`;
    timer = 60;
    timerElement.innerHTML = `Time: ${timer}`;
    prepareNextWord();
});

coinsElement.innerHTML = `Coins: ${wordCoins}`;
fetchRandomWord(); // Fetch the initial word for the game
prepareNextWord(); // Prepare the first word