# # Usar uma imagem Node para fazer o build da aplicação
# FROM node:20.17.0-alpine AS build

# # Definir o diretório de trabalho dentro do contêiner
# WORKDIR /app

# # Copiar os arquivos package.json e package-lock.json
# COPY package*.json ./

# # Instalar dependências
# RUN npm ci --omit=dev

# # Copiar todo o código para o diretório de trabalho
# COPY . .

# # Instalar o Angular CLI globalmente
# # RUN npm install -g @angular/cli
# # Rodar o build da aplicação
# RUN npm run build 
# #--configuration=production

# # Usar uma imagem Nginx para servir a aplicação
# FROM nginx:alpine

# # Copiar o build gerado do Angular para a pasta de arquivos estáticos do Nginx
# COPY --from=build /app/dist/tips-on-points2 /usr/share/nginx/html

# # Expor a porta 80 do Nginx
# EXPOSE 4200

# # Iniciar o servidor Nginx
# CMD ["nginx", "-g", "daemon off;"]

# Define node version
FROM node:20.17.0-alpine as build
# Define container directory
WORKDIR /usr/src/app
# Copy package*.json for npm install
COPY package*.json ./
# Run npm clean install, including dev dependencies for @angular-devkit
RUN npm ci
# Run npm install @angular/cli
RUN npm install -g @angular/cli
# Copy all files
COPY . .
# Run ng build through npm to create dist folder
RUN npm run build --prod
# Define nginx for front-end server
FROM nginx:1.15.8-alpine
# Copy dist from ng build to nginx html folder
COPY --from=build /usr/src/app/dist/tips-on-points2/browser /usr/share/nginx/html

#COPY nginx.conf /etc/nginx/nginx.conf
