using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace GameTest6 // Ensure this matches your project namespace
{
    public class HangmanGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SpriteFont _font;
        private List<char> guessedLetters = new List<char>();
        private string[] wordBank = { "MONOGAME", "HANGMAN", "DEVELOPER" };
        private string wordToGuess;
        private string displayWord = "";

        private int wrongGuesses = 0;
        private const int maxWrongGuesses = 6;

        private Texture2D[] hangmanParts; // Texture placeholders for hangman parts

        public HangmanGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Random random = new Random();
            wordToGuess = wordBank[random.Next(wordBank.Length)]; // Select a random word

            foreach (char c in wordToGuess)
            {
                displayWord += "_ "; // Creates blanks for each letter
            }

            hangmanParts = new Texture2D[maxWrongGuesses]; // Initialize array for hangman parts
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _font = Content.Load<SpriteFont>("FontFile"); // Add a font to your Content folder

            // Load hangman textures
            for (int i = 0; i < maxWrongGuesses; i++)
            {
                hangmanParts[i] = Content.Load<Texture2D>($"HangmanPart{i + 1}"); // Add images like HangmanPart1.png
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (wrongGuesses >= maxWrongGuesses || !displayWord.Contains("_"))
                return; // Stop updating if the game is over

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Escape))
                Exit();

            foreach (Keys key in keyboardState.GetPressedKeys())
            {
                char letter = (char)key;
                if (!guessedLetters.Contains(letter) && char.IsLetter(letter))
                {
                    guessedLetters.Add(letter);
                    ProcessGuess(letter);
                }
            }

            base.Update(gameTime);
        }

        private void ProcessGuess(char letter)
        {
            if (wordToGuess.Contains(letter))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == letter)
                    {
                        displayWord = displayWord.Remove(i * 2, 1).Insert(i * 2, letter.ToString());
                    }
                }
            }
            else
            {
                wrongGuesses++;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // Draw the guessed word
            _spriteBatch.DrawString(_font, displayWord, new Vector2(100, 100), Color.Black);

            // Draw the wrong guess count
            _spriteBatch.DrawString(_font, $"Wrong Guesses: {wrongGuesses}/{maxWrongGuesses}", new Vector2(100, 150), Color.Black);

            // Draw hangman parts based on wrong guesses
            for (int i = 0; i < wrongGuesses; i++)
            {
                _spriteBatch.Draw(hangmanParts[i], new Vector2(300, 200), Color.White);
            }

            // Draw game-over messages
            if (wrongGuesses >= maxWrongGuesses)
            {
                _spriteBatch.DrawString(_font, "Game Over! You Lose!", new Vector2(100, 250), Color.Red);
            }
            else if (!displayWord.Contains("_"))
            {
                _spriteBatch.DrawString(_font, "Congratulations! You Win!", new Vector2(100, 250), Color.Green);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
