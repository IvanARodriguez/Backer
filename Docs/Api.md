# Baker API

- [Baker API](#backer-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#login-request)
    - [Login](#login)
      - [Login Request](#register-login)
      - [Login Response](#login-login)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
	"userName": "John",
	"lastName": "Doe",
	"email": "j.doe@sample.com",
	"password": "johnDoePass01"
}
```

#### Register Response

```js
200 Ok
```

```json
{
	"id": "8f7db37b-f614-4b9b-b192-2c138a774061",
	"userName": "John",
	"lastName": "Doe",
	"email": "j.doe@sample.com",
	"token": "kasjdhksajdfyeewkjh"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
	"email": "j.doe@sample.com",
	"password": "johnDoePass01"
}
```

#### Login Response

```js
200 Ok
```

```json
{
	"id": "8f7db37b-f614-4b9b-b192-2c138a774061",
	"userName": "John",
	"lastName": "Doe",
	"email": "j.doe@sample.com",
	"token": "kasjdhks...ajdfyeewkjh"
}
```
