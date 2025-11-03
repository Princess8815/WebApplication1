# TESTING.md

## 🧠 Testing Philosophy

My testing approach focuses on **completeness, clarity, and real-world behavior**.  
Each function in the `UtilityServices` class — `CountVowels`, `IsLeapYear`, and `IsPalindrome` — was tested using the NUnit framework. I created targeted tests that verify correct outputs for valid data and robust handling of invalid or edge-case inputs. My goal was to ensure every public method behaves predictably regardless of what data is passed in, including unexpected or malformed inputs.

I began by identifying **logical partitions** of input values (normal cases, edge cases, and invalid cases) and wrote at least one test for each partition. For example, I tested `CountVowels` with lowercase, uppercase, mixed strings, and nulls; `IsLeapYear` with century years, divisible-by-four years, and negative numbers; and `IsPalindrome` with both numbers and strings of varying lengths, including empty and null values. I also organized the tests into clear sections within one file so that each function’s tests are grouped together for easy readability and maintenance.

---

## 📈 Coverage Analysis

I believe the test suite would catch nearly all forms of **bad data or incorrect logic**. The unit tests validate how each function responds to edge cases such as empty strings, null values, non-vowel characters, negative years, and non-palindromic numbers. For example, passing null or whitespace to `CountVowels` or `IsPalindrome` ensures the methods don’t crash and return safe defaults. Invalid leap year values such as negative or odd century years are also covered.

The tests are primarily designed to catch **logic errors** (like incorrect leap year rules), **boundary issues** (such as year 0 or single-character palindromes), and **case-sensitivity bugs** (for example, verifying that `RaceCar` is still recognized as a palindrome).  
The main scenarios not tested are large input performance tests or locale-specific characters (like accented vowels), since those go beyond the project’s current scope and would require additional handling in the implementation.

---

## 🧾 Test Summary

- **Total Tests Written:** 33  
  - `CountVowels`: 8 tests  
  - `IsLeapYear`: 10 tests  
  - `IsPalindrome`: 15 tests (including mixed string and numeric cases)

The largest challenge I encountered was **ensuring the `IsPalindrome` function could handle both integers and strings**. Initially, my method only accepted integers, which caused compilation errors in tests. I solved this by overloading the method with both `int` and `string` versions and normalizing the string input. Another challenge was designing meaningful null and edge-case tests that would fail gracefully instead of throwing exceptions. Overall, the process helped me understand how well-structured tests can both verify correctness and guide the evolution of cleaner, safer code.
