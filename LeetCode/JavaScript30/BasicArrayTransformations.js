
// Apply Transform Over Each Element in Array

var map = function (arr, fn) {
    var resultList = []
    for (var i = 0; i < arr.length; i++)
        resultList.push(fn(arr[i], i))
    return resultList
};


// Filter Elements from Array

var filter = function (arr, fn) {
    var resultArray = []
    for (var i = 0; i < arr.length; i++)
        if (fn(arr[i], i))
            resultArray.push(arr[i])
    return resultArray
};



// Array Reduce Transformation

var reduce = function (nums, fn, init) {
    var accum = init
    nums.forEach(function (item) {
        accum = fn(accum, item)
    })
    return accum
};