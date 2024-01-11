Here is a JavaScript solution for the problem:

```javascript
function findTriplets(arr) {
    let triplets = [];
    arr.sort((a, b) => a - b);
    for (let i = 0; i < arr.length - 2; i++) {
        if (i > 0 && arr[i] === arr[i - 1]) continue;
        let j = i + 1;
        let k = arr.length - 1;
        while (j < k) {
            let sum = arr[i] + arr[j] + arr[k];
            if (sum === 0) {
                triplets.push([arr[i], arr[j], arr[k]]);
                while (arr[j] === arr[j + 1]) j++;
                while (arr[k] === arr[k - 1]) k--;
                j++;
                k--;
            } else if (sum < 0) {
                j++;
            } else {
                k--;
            }
        }
    }
    return triplets;
}

console.log(findTriplets([-1, 0, 1, 2, -1, -4]));
```

This script will find all unique triplets in the array that sum to zero. It first sorts the array, then iterates over it, and for each element, it uses a two-pointer approach to find pairs that sum up to the negative of the current element. This way, it ensures that the sum of the triplet is zero. It also skips duplicate elements to ensure that the triplets are unique.