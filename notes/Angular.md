# Angular 

## Setting up Angular
- To install angular globally
    - `npm instal -g @angular/cli`
- Creating a new angular application
    - `ng new`
- Serve the angular application
    - `ng serve --open`

## What is Angular?
Angular is a modern frontend framework that allows you to create Single Page Applications

## Single Page Applications
- It's a type of web application, where instead of being composed of multiple html page, the information is on a SINGLE PAGE and that PAGE is swapped to display different views.
- In Web 1.0 each GET request to a url was responded with an HTML document. However, as the frontend matured and we started expecting more out of html/css/js, we began to think about ways to render html pages dynamically without having to refresh. Single Page Application Loads all its assests (aka html/css/js files + anything else it needs to function minus the data) in the first GET request, and afterward there is no page refresh. The URL changes you see is simulated. When users navigate to different pages, differnt parts of the html document is dynamically swapped out.

Tools such as Angular, React, Vue help developers create Single Page Application

## Advantages of SPA
- Modularity(promoting code reusability, scoping, and providing single source of truth)
- faster load times after the initial load

## Disadvantage of SPA
- initial load takes longer than server side rendering
- learning curve with tools

### Framework vs. Library
Framework are usually more opinionated on how it wants to functions, where as libraries are collections of tools. Frameworks are heavier and provide all-in-one support (ex. Angular, ASP.NET). Libraries are lighter in size and provide you with a certain set of functionality (ex. React, Serilog)



## Moving parts of Angular
### Component
Component is a reusable bundle of html/css/ts. components handle presentation logic.
When you generate component using `ng generate component <component-name>` or `ng g c <component-name>`it comes with html, css, ts, and ts testing file.

### Decorator
Decorator is a special syntax that lets angular know that it is angular's element. usually they start with `@` symbol, followed by the name, such as `@Component`, `@Directive`, `@NgModule`,`@Injectable`,`@Pipe` and more. After the syntax comes configuration object that we can use to define different properties associated to the element

### Modules
Angular module is very similar to namespaces in C#. Like how we bundle or register different types to a namespace, we register different angular elements to a module. Each component has to be declared in a single(one and only one) module. In order for other modules to have access to components declared in different modules, you need to export that component in you module, and then you need to import that particular module in module.ts file. Modules are decorated with `@ngModule` decorator that contains information regarding its members (components in declarations property), it dependenceies (imports property) and what it exports, and so on and so forth
