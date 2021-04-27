'use strict'
//spidermonkey
let cases = readline();

let allDays = [];
for (let i = 0; i < cases; i++) {
    let tester = readline().split(' ');
    for (let y = parseInt(tester[0]); y < parseInt(tester[1]) + 1; y++) {
        allDays.push(y)
    }    
}
let distinctDays = [...new Set(allDays)]

console.log(distinctDays.length)

