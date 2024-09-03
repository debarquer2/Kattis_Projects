# Kattis
 A repo for various Kattis projects.

##FizzBuzz1
Based on: https://open.kattis.com/problems/fizzbuzz

A variation on classic FizzBuzz

##FizzBuzz2
Based on https://open.kattis.com/problems/fizzbuzz2

The task is to find the most accurate FizzBuzz string amongst a number of candidates.
My solution was to loop through the submitted answers and compare each integer to what my program would consider to be the correct answer for that integer. The one with the most correct answers is selected, and
in the case of a tie the first one iterated through is selected.

##Heimavinna
Based on https://open.kattis.com/problems/heimavinna

The task is to count numbers. The numbers come either in pairs, for example "1-3", "5-8" or "10-15", or alone such as "1", "5", or "18". A complete example string could look like "1-3;5;7;10-13".

My solution was to identify the various components of the string. Each number ends with a ";" character (or the end of the file in the case of the last number). Then either add 1 if the number is a single number,
or add the difference between the numbers plus one in the other case. At the end I do the check again to account for the last number not ending with the ";" character.

##Arrangement
Based on https://open.kattis.com/problems/upprodun

The task is to assign a number of people as evenly as possible to a number of rooms.

There are two options for each room, either it will contain m / n people or m / n + 1 people.
My solution was to assign each room the m / n people and then assign the extra people from a pool of people until the pool is exhausted.

I also experimented with a more optimized version which pre-creates the string and therefore saves a nested loop.

##Calculator
Based on https://open.kattis.com/problems/calculator

The task is to create a calculator able to handle order of operations and parenthesis. 
This project is a work-in-progress and incomplete as it handles white spaces incorrectly.