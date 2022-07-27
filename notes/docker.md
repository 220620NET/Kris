# Docker
Is a containerization platform that allows developers to package their application alongside with their dependencies in on convenient place!

# Containerization
- Is a way to provide *uniform environment* to run our app regardless of whichever machine we end up in.

# Terms
- docker engine
  - is the deamon (the thing that sits in the background )

- dockerfile
  - Is a file of instruction to docker engine in order to create a file system(or Image) that has everything you need to run your app(your app, your dependencies, your runtime, etc.)

- dockerignore
  - gitignore file for docker

- Image
  - is a **file system** that contains your application artifacts, your dependencies, runtime, reverse proxy, etc, whatever you need to run your application

- Container
  - Virtualized OS/software
  - Resources are dynamically allocated (in VM's resources are statically allocated)
  - It's smaller (in 100's of Mb's and maybe a few Gb's)

- Image Registry
  - Is a place to upload/download/share images. Docker hub is one of the biggest image registries for docker images, and this is like what github is to git.

-both containers and virtual machines achieve the same goal -> being able to run isolated environments regardless of host machine

# Docker CLI Commands
- To run local images:
  - `docker run <image-name>`
  - `-d` "detached"  runs the container in the background
  - `-p host: container` to map container port to host machine
  - ` docker run -d -p 8080:8080 aschil/snake`
- To see all your local images:
  - `docker image ls`
- To delete an image from your local images
  - `docker image rm image-id`
- These work with containers as well
