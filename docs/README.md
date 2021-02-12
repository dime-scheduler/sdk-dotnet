# Website

This website is built using [Docusaurus 2](https://v2.docusaurus.io/), a modern static website generator.

## Installation

```console
yarn install
```

## Local Development

```console
yarn start
```

This command starts a local development server and open up a browser window. Most changes are reflected live without having to restart the server.

## Build

```console
yarn build
```

This command generates static content into the `build` directory and can be served using any static contents hosting service.

## Deployment

Run this script in the repository's root:

```console
set "GIT_USER=hbulens" && yarn deploy
```

Replace 'hbulens' with your GitHub user name.

If you are using GitHub pages for hosting, this command is a convenient way to build the website and push to the `gh-pages` branch.
