# Question: How do you find all unique triplets in an array that sum to zero? JavaScript Summary

The JavaScript function `findTriplets` is designed to find all unique triplets in an array that sum to zero. The function first sorts the input array in ascending order. It then iterates over the sorted array, but only up to the third last element, as we need at least three elements to form a triplet. If the current element is the same as the previous one, it skips to the next iteration to avoid duplicate triplets. For each iteration, it uses a two-pointer approach, initializing one pointer (`j`) to the next element and the other pointer (`k`) to the last element of the array. It then enters a while loop, which continues as long as `j` is less than `k`. Inside the loop, it calculates the sum of the elements at the current indices `i`, `j`, and `k`. If the sum is zero, it adds the triplet to the result array and moves both pointers inward, skipping any duplicate elements. If the sum is less than zero, it moves the `j` pointer to the right (increasing the sum), and if the sum is greater than zero, it moves the `k` pointer to the left (decreasing the sum). The function finally returns the array of all unique triplets that sum to zero.

---

# TypeScript Differences

The TypeScript solution is very similar to the JavaScript solution. Both solutions use the same logic and algorithm to solve the problem. They first sort the array, then iterate over it, and for each element, they use a two-pointer approach to find pairs that sum up to the negative of the current element. This way, they ensure that the sum of the triplet is zero. They also skip duplicate elements to ensure that the triplets are unique.

The main difference between the two solutions is that the TypeScript version includes type annotations. TypeScript is a statically typed superset of JavaScript, which means it adds static types to the language. This can help catch errors during development and make the code more readable and self-documenting.

In the TypeScript version, the function parameter `nums` is annotated with the type `number[]`, indicating that it is an array of numbers. The return type of the function is also annotated as `number[][]`, indicating that it returns an array of arrays of numbers. The variable `result` is also explicitly declared as an array of arrays of numbers (`number[][]`). These type annotations help ensure that the function is used correctly, and can help catch type-related errors during development. 

Other than these type annotations, the TypeScript and JavaScript versions of the solution are identical.

---

# C++ Differences

The C++ version of the solution uses the same logic as the JavaScript version to solve the problem. Both versions first sort the array, then iterate over it, and for each element, they use a two-pointer approach to find pairs that sum up to the negative of the current element. This way, they ensure that the sum of the triplet is zero. They also skip duplicate elements to ensure that the triplets are unique.

However, there are some differences due to the language features and methods used in each version:

1. Array Manipulation: In JavaScript, arrays are dynamic and can be manipulated using built-in methods like `sort()` and `push()`. In C++, arrays are static and cannot be resized or sorted directly. Instead, the C++ version uses a `std::vector` (a dynamic array), and the `std::sort()` function from the `<algorithm>` library to sort the vector. To add elements to the result vector, it uses the `push_back()` method.

2. Looping: Both versions use for and while loops to iterate over the array and find the triplets. However, the C++ version uses the range-based for loop (`for (auto &v : result)`) to print the result, which is a feature not available in JavaScript.

3. Printing: The JavaScript version uses `console.log()` to print the result, while the C++ version uses `std::cout` from the `<iostream>` library.

4. Type Checking: JavaScript is dynamically typed, so there's no need to specify the type of a variable when it's declared. C++, on the other hand, is statically typed, so the type of each variable must be declared.

5. Function Declaration: In JavaScript, functions are declared with the `function` keyword, while in C++, functions are declared with the return type (in this case, `std::vector<std::vector<int>>`).

6. Main Function: The C++ version includes a `main()` function, which is the entry point of the program. This is a requirement in C++, but not in JavaScript.

---
