//  generate a random integer between 1 and 100
function randomInt() {
    return Math.floor(Math.random() * 100) + 1;
}

// Initialize game variables
let secretNumber = randomInt();
let guesses = [];
let turns = 10;

//  start a new game
function startAgain() {
    secretNumber = randomInt();
    guesses = [];
    turns = 10;
    document.getElementById('result').textContent = '';
    document.getElementById('guesses').textContent = 'Previous guesses: ';
    document.getElementById('guessInput').value = '';
    document.getElementById('guessButton').disabled = false;
    document.getElementById('startAgainButton').style.display = 'none';
}

//  check the player's guess
function Guess() {
    const guess = parseInt(document.getElementById('guessInput').value);
    if (isNaN(guess) || guess < 1 || guess > 100) {
        alert('Please enter a number between 1 and 100.');
        return;
    }

    if (guesses.includes(guess)) {
        alert('You have already guessed that number.');
        return;
    }

    guesses.push(guess);
    turns--;

    if (guess === secretNumber) {
        document.getElementById('result').textContent = 'Congratulations! You guessed the right number!';
        document.getElementById('guessButton').disabled = true;
        document.getElementById('startAgainButton').style.display = 'inline';
    } else if (turns === 0) {
        document.getElementById('result').textContent = `Game over! The secret number was ${secretNumber}.`;
        document.getElementById('guessButton').disabled = true;
        document.getElementById('startAgainButton').style.display = 'inline';
    } else {
        let hint = guess < secretNumber ? ' too low.' : ' too high.';
        document.getElementById('result').textContent = `Incorrect! You have ${turns} turns left. Your guess was${hint}`;
    }

    document.getElementById('guesses').textContent = 'Previous guesses: ' + guesses.join(', ');
}

window.startAgain = startAgain;
window.Guess = Guess;
