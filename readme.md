# API Boss

[Get downloadable unity package here](https://github.com/masterprompt/ApiBoss/raw/master/Assets/Packages/)

#### Unity API Library

Simplifies using [UnityWebRequest](https://docs.unity3d.com/ScriptReference/Networking.UnityWebRequest.html) by providing a [fluent](https://en.wikipedia.org/wiki/Fluent_interface) interface for common API client needs.  Some basic examples are included in the example scene which uses a [Testing API](https://github.com/typicode/jsonplaceholder#how-to).

#### Tested with:
| Unity Version | Status |
| ------ | ----------- |
| 2018.1.3f1   | OK |

## How to

Here's some code using API Boss

### Getting a resource

```c#
    Request
        .Get("https://jsonplaceholder.typicode.com/posts/1")
        .OnJsonResponse<JsonResponse>(OnResponse)
        .Send();
```

### Posting a resource

```c#
    Request
        .Post("https://jsonplaceholder.typicode.com/posts")
        .SetJsonPayload(payload)
        .OnJsonResponse<JsonResponse>(OnResponse)
        .SetHeader("Content-type","application/json; charset=UTF-8")
        .Send();
```

Note: the resource will not be really created on the server but it will be faked as if. 

### Putting a resource

```c#
    Request
        .Put("https://jsonplaceholder.typicode.com/posts/1")
        .SetJsonPayload(payload)
        .OnJsonResponse<JsonResponse>(OnResponse)
        .SetHeader("Content-type","application/json; charset=UTF-8")
        .Send();
```

Note: the resource will not be really updated on the server but it will be faked as if. 

### Deleting a resource

```c#
    Request
        .Delete("https://jsonplaceholder.typicode.com/posts/1")
        .OnError(Helpers.LogError)
        .OnResponse(Helpers.LogResponse)
        .Send();
```

## Operations

_TBD_
