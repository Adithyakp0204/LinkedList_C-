# Linked List Implementation in C#

This repository contains a simple implementation of a **singly linked list** in C# for educational purposes.


## 🔍 What is a Linked List?

A **Linked List** is a linear data structure where each element (called a "node") contains:
- A **data** value.
- A reference (or link) to the **next node** in the sequence.

Unlike arrays, linked lists do not store elements in contiguous memory locations. They are dynamically allocated, making insertion and deletion operations more efficient in certain scenarios.

---

## 📘 Features Implemented

- ✅ Create a Node class that stores `int` data and a pointer to the next node.
- ✅ Insert new elements at the end of the list.
- ✅ Search for an element in the list (`Contains` method).
- ✅ Print all elements in the list.

---

## 🧠 Code Structure

### `Node` Class

Search an element in a Linked List (Iterative and Recursive)
Given a linked list and a key, the task is to check if key is present in the linked list or not. 

Examples:
Input: 14 -> 21 -> 11 -> 30 -> 10, key = 14
Output: Yes
Explanation: 14 is present in the linked list.

Input: 6 -> 21 -> 17 -> 30 -> 10 -> 8, key = 13
Output: No
Explanation: No node in the linked list has value = 13.

Input: 9 -> 18 -> 27 -> 36 -> 45, key = 27
Output: Yes
Explanation: 27 is present in the linked list.


