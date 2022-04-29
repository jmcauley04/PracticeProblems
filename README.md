# PracticeProblems

This project is just for reference - a list of problems for practice.

## Projects

- PracticeProblems - This project holds the problems
- ChallengeTests - This project allows the user to write their own tests, if desired
- SolutionTests - This project stores the solution tests

## Terms

### Big O

- Time - The upper bound of the time it takes to perform an algorithm
- Space - the upper bound of how much memory it takes to perform an algorithm
- O(1) - constant complexity; 1 represents any stable complexity
- O(n) - proportionate complexity; the complexity increases proportionately with the size of the enumeration
- O(n^2) - squared complexity; for every element in the enumeration, the complexity increases by the size of the enumeration
- O(n^x) - x complexity; for every element in the enumeration, the complexity increases by the size of the enumeration to the (x-1) power.


## Planned Problems

### Array and String

- Anagrams - Write a function that takes two strings and returns a boolean representing whether the two strings are anagrams of each other.  
	- An anagram of a string is another string that matches the first string in all ways except order of characters.
- Most frequent char - Write a function that takes a string and returns the most frequent char found in the string.
- Pair sum - Write a function that takes an array and returns a new array of all pair sums of the original array.
	- ie. {1, 2, 3} => {1 + 2, 1 + 3, 2 + 3} = {3, 4, 5}
- Pair product - Write a function that takes an array of distinct elements and a number and returns a boolean representing whether the array contains a pair whose product is the number.

<ul>
	<li>
		<p>
		  You're given an array of positive integers representing the prices of a single stock on
		  various days (each index in the array represents a different day). You're also
		  given an integer <span>k</span>, which represents the number of transactions
		  you're allowed to make. One transaction consists of buying the stock on a
		  given day and selling it on another, later day.
		</p>
		<p>
		  Write a function that returns the maximum profit that you can make by buying
		  and selling the stock, given k transactions.
		</p>
		<p>
		  Note that you can only hold one share of the stock at a time; in other words,
		  you can't buy more than one share of the stock on any given day, and you can't
		  buy a share of the stock if you're still holding another share. Also, you
		  don't need to use all k transactions that you're allowed.
		</p>
	</li>
</ul>

### Linked Lists

<ul>
	<li>
		<p>
		  Write a function that takes in the head of a Singly Linked List and an integer
		  <span>k</span>, shifts the list in place (i.e., doesn't create a brand new
		  list) by k positions, and returns its new head.
		</p>
		<p>
		  Shifting a Linked List means moving its nodes forward or backward and wrapping
		  them around the list where appropriate. For example, shifting a Linked List
		  forward by one position would make its tail become the new head of the linked
		  list.
		</p>
		<p>
		  Whether nodes are moved forward or backward is determined by whether
		  <span>k</span> is positive or negative.
		</p>
		<p>
		  Each <span>LinkedList</span> node has an integer <span>value</span> as well as
		  a <span>next</span> node pointing to the next node in the list or to
		  <span>None</span> / <span>null</span> if it's the tail of the list.
		</p>
		<p>
		  You can assume that the input Linked List will always have at least one node;
		  in other words, the head will never be <span>None</span> / <span>null</span>.
		</p>
	</li>
</ul>

### Binary Tree

See source [structy]...

### Graph

See source [structy]...

### Dynamic Programming

See source [structy]...

### Stack

See source [structy]...

### Exhaustive Recursion

See source [structy]...

### Mixed Recall

See source [structy]...

## Sources:

- [structy](https://structy.net/problems/zipper-lists/problem-index)
- [AlgoExpert](https://www.algoexpert.io/)
