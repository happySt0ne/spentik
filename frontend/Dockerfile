FROM node:14.21.1-alpine

#create a working directory inside the container.
WORKDIR /app

#Environment variables.
ENV PATH /app/node_modules/.bin:$PATH

#copy the files from the host to the container.
COPY package.json ./
COPY package-lock.json ./

#install npm and react versions.
RUN npm install 
RUN npm install react-scripts@5.0.1 -g --silent
RUN npm install -g nodemon

#install nodemon to provide hot-reloading functionality.
# RUN npm install nodemon --save-dev
COPY . ./

#use nodemon to run the react application using npm.
# CMD ["nodemon", "--exec", "npm", "start"]
CMD ["nodemon", "server.js"]
