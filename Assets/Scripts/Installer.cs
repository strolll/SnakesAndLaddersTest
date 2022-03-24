using UnityEngine;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Installer : MonoBehaviour
    {
        [SerializeField]
        private Ui ui;

        [SerializeField]
        private GameView gameView;

        private void Start()
        {
            // Instigate
            Game game = new Game();
            IDice dice = new DiceUnityRandom();
            Board board = new Board();
            Turn turn = new Turn();
            IPause pause = new PauseUnityTimeScale();

            //TODO: DI 


            //TODO: Event binding
            

            // Initialise
            ui.Init();
            gameView.Init();
            game.Init();

            // Run
            ui.ShowMenuScreen();

        }
    }
}