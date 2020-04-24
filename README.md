# MongoDB
This is a PoC (prove of convept) of implementing a MongoDB repository

# Use the MongoDB docker
Use the following docker commands to make it run:

Get the docker image:
```dockerfile
docker pull mongo
```

Rrun the image and expose default MongoDB port:
```dockerfile
docker run --name mongodb -v mongodata:/data/db -d -p 27017:27017 mongo
```

If the docker is stoped in any moment, start it again with:
```dockerfile
docker start mongodb
```
