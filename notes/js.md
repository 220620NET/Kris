# Javascript

Javascript to Java is Hamster is to Ham

Javascript is a loosely typed functional programming language. They are interpreted by browser engine at run time (Nowadays, they do JIT compiling). This is the native language of choice for browsers. Server side JS is Node.js 
The js standard is known as ECMAScript (current: ECMAScript2021)

## Javascript Types
- String
- Undefined
- Number
- Boolean
- Object
- Null
- Symbols

## Comparison
- == : type coerces
- ===: comparison

## Different keywords to declare variables
- var: the old school way (please do not use this)
Introduced in ES6
- let: for storing any value 

## Truthy and Falsey values
- Falsey values: FUN0NE(False, Undefined, Null, 0, NaN, EmptyString)
- 0 is falsey, anything not 0 is truthy
- "" is falsey, any non-empty string is truthy
- undefined, null are both falsey
- NaN (in fact a number type) falsey

## DOM (Document Object Model)
Is how CSS and JS interacts with HTML elements. It is a tree like structure

## Events
JS primarily interacts with HTML/DOM through events. Browsers keep track of many different types of events and users can attach their event handlers(js function made to respond to a certain event) to these events

### Event Propagation
Once the event reaches the target element, it "bubbles" up to the window. As it bubbles up, it can trigger all of its parents related to the
## Making HTTP Calls
- XML
- FetchAPI

## JS Object vs JSON
JSON is a notation to transport data derived from JS objects.

## Storage
- cookie
- Web Storage API
    - Local Storage
        - Persists through sessions
    - Session Storage
        - Gets wiped when the user closes the tab
