# Notes

* ⚠️ **WIP**
* ✅ **GREEN**
* 🧠 **In Discovery**
* ❌ **RED**
* 📝 **TBD** 

# Test Strategy for Tic Tac Toe Game

---

## 1. Overview

This test strategy outlines the tests that will be written for the Tic Tac Toe game to ensure all functionality works as expected. 
We will use xUnit for testing, and the testing will follow an incremental Test-Driven Development (TDD) approach.

---

## 2. Goals

- Ensure that all parts of the game work correctly.
- Test all classes and methods individually (unit tests).
- Cover key functions like board, placing markers, checking the winner, and the game flow (turn switching, game progression, etc.).

---

## 3. Overall Testing Strategy

We will test the following classes:

- **Board**: Represents the game board, handles the cells, and checks for winning conditions.
- **Player**: Represents a player and their marking symbol (`X` or `O`).
- **Game**: Manages the game logic, player turn switching, and checks for a winner.

---

## 4. Test Plan Per Class

### 4.1 Tests for the `Board` Class

**Functionality to be tested:**
- Initialize the board and check that all cells are empty.
- Place markers on the board.
- Ensure markers are placed only on empty cells.
- Verify that winning conditions are checked across rows, columns, and diagonals.

**Specific tests:**
- **Initialize Board:**
    - Test that a newly created board has all empty cells with `' '` (empty values).
- **Place Markers:**
    - Test that placing a marker on an empty cell is successful.
    - Test that a marker cannot be placed on an already filled cell.
    - Test that the correct marker is placed.
- **Check Winner:**
    - Test that a winner is found for whole rows, columns, and diagonals.
    - Test that the board returns `' '` (no winner) if no winner exists.

### 4.2 Tests for the `Player` Class

**Functionality to be tested:**
- Represent a player with a marking symbol (`'X'` or `'O'`).
- Switch turns between players correctly.

**Specific tests:**
- **Create Player:**
    - Test that a player is created with the correct marker (`'X'` or `'O'`).
- **Switch Player:**
    - Test that the turn switches between players properly.

### 4.3 Tests for the `Game` Class

**Functionality to be tested:**
- Handle the entire game logic (turn switching, winner checks, and game conclusion).
- Allow players to make their moves.
- Ensure the game ends when a winner is found.

**Specific tests:**
- **Play Move:**
    - Test that each move is recorded correctly on the board.
    - Test that the game switches turns after each move.
- **Game End:**
    - Test that the game ends when a winner is found.
    - Test that the game can handle a draw (all cells filled without a winner).
- **Winning Combinations:**
    - Test that the game correctly determines a winner.

---

## 5. Test Prioritization

1. **Fundamentals:**
    - Test board initialization.
    - Test placing markers correctly on the board.
    - Test player turn switching.
2. **Game Flow:**
    - Test winning rows and columns.
    - Test that the game ends when a winner is found.
3. **Edge Cases:**
    - Test all possible winning combinations (rows, columns, and diagonals).
    - Test that the game handles a draw scenario properly.

---

## 6. Test Data

Test data for the board: Use a 3x3 board where all cells are initially empty. Use marking data such as `'X'` and `'O'`, and validate the board after each move.

Example data:
- Game 1: `X` places on (0, 0), `O` on (0, 1), and so on.
- Game 2: For tests of full rows, example:
    - `X` on (0,0), (0,1), (0,2) should give a winner.

---

## 7. Reporting and Follow-Up

- **Test Completion & Regression Testing:** After any changes, regression tests will be run to ensure that no existing functionality is broken.
- **Test Suites:** Test suites will be run continuously via a CI/CD pipeline to receive quick feedback and address any issues as soon as they arise.

---

## Summary

The test strategy is focused on thoroughly testing the functions such as player moves, board setup, and game logic (turn switching and winner checks) to ensure the entire application is robust and error-free before it is used in practice. We will work incrementally from basic functionality to more complex features like game-ending handling and user-related tests.
