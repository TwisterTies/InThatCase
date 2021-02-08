function guessLetter(letter) {
        let id = document.getElementById('hidden-game-id').value;
        let xhr = new XMLHttpRequest();
        let url = `/api/game/${id}/guess`
        xhr.open("POST", url, true);
        xhr.setRequestHeader("Content-Type", "application/json");

        xhr.onreadystatechange = function(event) {
            if (event.target.readyState == XMLHttpRequest.DONE) {
                let fuckmyLife = JSON.parse(event.target.responseText);
                changeHangmanAndMax(fuckmyLife.nrOfIncorrectGuesses);
                setTextArray(fuckmyLife.wordToGuess.word);
            }
        }
        var data = JSON.stringify({ "letter": letter });
        xhr.send(data);
        document.getElementById(`${letter}`).disabled = true;
        return letter;
}

function changeHangmanAndMax(maxTry){
    document.querySelector(".maxTry").textContent = `${maxTry}`;
    switch (maxTry) {
    case 1:
        document.getElementsByClassName("pole")[0].style.visibility = "visible";
        break;
    case 2:
        document.getElementsByClassName("shaft")[0].style.visibilty = "visible";
        break;
    case 3:
        document.getElementsByClassName("rope")[0].style.visibility = "visible";
        break;
    case 4:
        document.getElementsByClassName("man")[0].style.visibility = "visible";
        break;
    }
}

function setTextArray(wordString) {
    var splitWord = wordString.split('');
    var input = guessLetter();
    if (splitWord.includes(input)) {
        console.log('Yes, the letter is inside of the array!');
    } else {
        console.log('No, that letter is not included!');
    }
    
}

