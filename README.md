# RPS game

# Rock-Paper-Scissors

While getting to know the ins and outs of while loops (no pun intended), I started looking for a fun, yet not too difficult way to put my newly found knowledge to use. The well-known game Rock-Paper-Scissors seemed to fit the bill perfectly, mostly because of its simplicity and familiarity. To go the extra mile, I've added a computer opponent, the option to continue or quit after a match, and lastly, some colored text depending on the outcome.

First, the user is asked to select one of the three options, and the choice is stored in the `int userChoice` variable, which is checked by an `if` statement to determine if the user's choice was either 1, 2, or 3. If so, the program exits the loop; otherwise, it repeats the cycle. The `string[] options = { "Rock", "Paper", "Scissors" };` line declares an array or a collection of strings named `options`. Now that I think about it, it would be quite funny to add `fire` as a reference to that [Friends episode](https://www.youtube.com/watch?app=desktop&v=lMCE2cvR7tg).

Then we have the `Random rnd = new Random();` part. Let's dissect it, shall we? The `Random` C# class is used to generate a random object, for example, a number. `Random rnd` therefore creates an instance of the Random class named `rnd`, similar to declaring `int carSpeed` or `var favouriteColor`. Finally, there's the `new Random()` part, which initializes this instance.
The last tricky bit is the `rnd.Next(1, 4);` method, which generates a random integer between 1 and 3 (inclusive of 1, exclusive of 4). In other words, 1 represents an inclusive lower bound, and 4 is an exclusive upper bound.

After each side selects their option, a simple `Console.WriteLine` informs the user about it and proceeds to do a comparison via an `if` statement. When the program is finished, it informs the user about the results. If the player wins, the text is green; if the computer wins, it's red; and cyan if it's a tie. If it's a tie, the game automatically starts over. If it's a victory or loss, the user needs to decide if they would like to continue or quit by pressing either `y` or `n`.

I don't know but for some reason, I honestly had more fun coding it and scrambling for answers than playing it.

