# Typescript
## Node.js
Node.js is a serverside interpreter/environment for javascript. NodeJS also comes with NPM, Node Package Manager, which is similar to NuGet in C#
## NPM
Node Package Manager. We use NPM to manage our dependencies for js projects, as well as write scripts that we can run by doing `npm <name>`. In order to install packages from NPM we use `npm install` or `npm i` command followed by the package name. For example `npm install typescript`. When we install packages, they go in the special folder named node_modules. You can use `--global` to install the package accessible everywhere in your machine, or you can use `--save` to save the package as your project dependency. `--save-dev` saves the package information as you dev dependency

## NPX
Node package runner: We use this to run the typescript compiler `tsc` to "transpile" the typescript file to a js file
## Typescript
In order to run locally installed typescript, first install the package and then run `npx tsc`("typescript compiler")
Typescript is a superset of javascript, or as people like to say, if you make OOP developers code in javascript, they'll come up with typescript.
Typescript is a static typed language, which means that it will enforce you to define types as you declare variables. Instead of doing `let foo= 'bar'`, we have to define the type by doing `let foo:string='bar'`

Typescript is not natively understood by browsers, so we have to transpile it down to javascript. Do it by `npx tsc <file-path>`. If you don't want to run this everytime you change, you can use the `--watch` tag
Typescript enforces type safety by having you declare types for your variables. But it is still javascript under the hood.
# Additional Typescript Features
## Additional Types
TS introduces types that don't exist in Javascript, such as any, void, never, and more!
- Any type is when you ant to use ts like js. really any data type can be assigned to the variable
- Void is exclusively used for functions. Just means function does not return anything
- never is for something that will never be anything - usually used for functions that will always throw an error
- Union types
## Access modifiers for class
Typescript introduces access modifiers for classes that doesn't exist in js
## Interfaces
Typescript interface is a way to define a shape of an object. Typescript will then enforce that the properties of interface exists in an object when we claim that an object is of a certain type. Interface is useful when we are only interested in enforcing certain shape in an object but not interested in defining behaviors. Typescript uses duck typing, or structural typing, which checks for the existence of properties.