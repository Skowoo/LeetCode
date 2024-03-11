
// Function Composition
var compose = function (functions) {    
    return function (x) {
        for (let i = functions.length - 1; i >= 0; i--)
            x = functions[i](x)

        return x
    }
};


// Return Length of Arguments Passed
var argumentsLength = function (...args) {
    return args.length
};


// Allow One Function Call
var once = function (fn) {
    let called = false
    return function (...args) {
        if (!called) {
            called = true;
            return fn(...args)
        }
        else return undefined
    }
};


// Memoize
function memoize(fn) {
    const memory = {};
    return function (...args) {
        if (args in memory)
            return memory[args];

        let result = fn(...args);

        memory[args] = result;

        return result;
    }
}