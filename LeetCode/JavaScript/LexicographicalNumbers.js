/**
 * @param {number} n
 * @return {number[]}
 */
var lexicalOrder = function (n) {
    return Array
        .from({ length: n }, (_, i) => (i + 1)
            .toString())
        .sort()
        .map(Number)
};