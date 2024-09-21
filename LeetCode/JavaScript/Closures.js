var createHelloWorld = function () {
    return function (...args) {
        return "Hello World"
    }
};

var createCounter = function (n) {
    var curVal = n
    return function () {
        return curVal++
    };
};

var expect = function (val) {
    return {
        toBe: function (n) {
            if (val === n)
                return true
            else
                throw new Error("Not Equal")
        },
        notToBe: function (n) {
            if (val !== n)
                return true
            else
                throw new Error("Equal")
        }
    }
};

var createCounter = function (init) {
    var initialValue = init
    var currentValue = init

    return {
        increment: function () {
            return ++currentValue
        },
        decrement: function () {
            return --currentValue
        },
        reset: function () {
            currentValue = initialValue
            return currentValue
        }
    }
};