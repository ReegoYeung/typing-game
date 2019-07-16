INTRODUCTION
-----------
1.This typing game is implemented by WPF(C#).
2.If the "words" fall from the top to the black line then the player is set to be hurt.
3.A player has 5 lives.
4.A player has 60 seconds to play.

START
-----------
1. There are three difficulties that can be chosen by player: Normal, Hard and Hell.
2. In Normal Level, falling words are names of fruit.
3. In Hard Level, falling words are names of animals.
4. In Hell Level, falling words are names of countries (where long countries name are removed).
5. There are always four falling words without repetition.

RULE
-----------
1. If the words fall from the top to the black line then the player will be hurt.
2. Player has 5 lives only.
3. Player has 60 seconds only.
4. Player can choose one of the three difficulties to play.

DESIGH
-----------
1. To make the typing game less boring, there are three difficulties to be chosen by player.
2. To make the typing game less boring, the foreground and blackground color of falling words will be changed randomly.
3. To lower the difficulties, there is no repeated falling words at the same time. The four falling words must be different all the time.
4. This project uses Model-View-Controller as design pattern.
5. WPF is the View which display the GUI.
6. class Game is the only Model in this project. It stores all data and logic of this project.
7. class WordController, GameOverController, InputBoxController and GameController are the Controller in this project.
8. WordController is used to initialize falling words, change the foreground and background color of falling words and controls the falling words.
9. GameOverController is used to display game over message when time is over or life is zero.
10. InputBoxController is used to check whther player input is equal to one of the falling words.
11. GameController is used to control every class above.
12. delegate is used to simulate the falling(movement) of falling words.


CREDIT
-----------
1. This typing game is written by Yeung Chor Wing (1155086093), an Information Engineering student of the Chinese University of Hong Kong.
2. This typing game is the individual project of Information and Software Engineerting Practice (IERG3080).