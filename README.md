

ionic APP API

## 接口说明

接口采用POST方式通过URL获取数据， 返回格式为json/text，utf-8编码。

retcode：

1. 正常情况下为0
2. 错误：

| 错误码 | 说明                      |
| ------ | ------------------------- |
| 11     | 参数错误                  |
| 12     | 服务器内部错误            |
| 13     | 认证令牌（authtoken）失效 |
| 99     | 未知错误                  |

返回参数说明：

| 参数名      | 类型   | 是否可空 | 备注                   |
| ----------- | ------ | -------- | ---------------------- |
| retcode     | 返回码 | 否       | 说明见上               |
| authtoken   | string | 是       | 用户登录标识（记录id） |
| info        | object | 是       | 返回数据               |
| pagecount   | int    | 是       | 总页码数               |
| recordcount | int    | 是       | 数据总条数             |
| isfirst     | bool   | 是       | 是否是第一页           |
| hasnext     | bool   | 是       | 是否有下一页           |
| items       | object | 是       |                        |
| debug       | string | 是       | 调试信息               |
| id          | int    | 是       | id                     |
| message     | string | 是       | 返回信息               |



```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {}
    ],
    "pagecount": 1,
    "recordcount": 10,
    "isfirst": true,
    "hasnext": true,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

测试工具：postman，默认请求方式：get

### 1.登录

```http 
http://localhost:5000/api/Launch/Login?username=&password=
```

参数：

| 参数名   | 类型   | 是否可空 | 备注 | PE-User表                         |
| -------- | ------ | -------- | ---- | --------------------------------- |
| username | string | 否       | 账号 | UserName或Email（其实一个就够了） |
| password | string | 否       | 密码 | Password                          |

返回：

| 字段      | 类型          | 说明     |            |
| --------- | ------------- | -------- | ---------- |
| retcode   | int           | 返回码   |            |
| authtoken | string        | 登录证书 |            |
| info      | array[object] |          | PE-User表  |
| id        | int           | 用户id   | Id         |
| name      | string        | 姓名     | RealName   |
| gender    | int           | 性别     | Sex        |
| phone     | string        | 手机号   | Mobile     |
| qq        | string        | qq       | Property05 |
| addr      | string        | 地址     | Address    |
| schoolId  | int           | 学校Id   | SchoolId   |
| school    | string        | 学校     | School     |

```json
{
    "retcode": 0,
    "authtoken": "97F02636E249793A37CED81599713373CF32DF9495F10BDD397063C90385D876",
    "info": {
        "id":"31308",
        "name": "陈勇",
        "gender": null,
        "phone": null,
        "email": null,
        "qq": null,
        "addr": null,
        "schoolId": null,
        "school": null
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": "2020-04-20T02:12:39.0277858Z",
    "message": "老师登录成功"
}
```



### 2.课程及内容

#### 1.课程

##### 1.获取教师课程列表



```http
http://localhost:5000/api/Course/GetCoursesList?authtoken=
```

参数：

| 参数名    | 类型   | 是否可空 | 说明     |
| --------- | ------ | -------- | -------- |
| authtoken | string | 否       | 登录证书 |

返回：

| 字段    | 类型          | 说明                          |
| ------- | ------------- | ----------------------------- |
| retcode | int           | 返回码                        |
| info    | array[object] | （对应PE-Course表，字段同名） |
| id      | int           | 课程id                        |
| name    | string        | 课程名称                      |
| intro   | string        | 课程简介                      |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 422,
            "name": "Java程序设计",
            "teacher": 31308,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": "<p>Java是一种简单的，面向对象的、分布式的、解释的、健壮的、可移植的、性能优异的多线程的动态语言。它经历了萌芽、发展和成熟阶段，现在已经成为 IT 领域里的主流编程语言，在众多领域得到广泛的应用。本课程以就业为导向，从高技能人才培养的要求出发，以强化技术应用能力培养为主线，构建理论教学体系和实践教学体系。</p>",
            "createUserId": 6045,
            "createTime": "2019-04-16T13:46:19.087",
            "updateTime": "2019-04-16T13:46:19.087",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": null,
            "logoText": "Java程序设计",
            "logoBackgroundColor": "rgb(27, 161, 226)",
            "isDel": false,
            "isBan": false,
            "status": 0,
            "ord": null,
            "pzycj": 0.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 0.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": false,
            "copyTimes": 0
        },
        {
            "id": 418,
            "name": "高级办公自动化（含视频）",
            "teacher": 31308,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": "课程简介：“大学计算机基础”课程，32学时，2学分，通识课程（公选课），适合非计算机专业学生。主要内容：计算思维基础与新一代信息技术简介；操作系统与因特网使用；办公自动化软件的高级运用。课程目标：掌握计算机科学与技术的基础知识、基本技能，提高学生应用计算机解决实际问题的能力。注重思维和素养培养，为学生的终生学习奠定基础，能够更好地使用计算机及相关技术来解决本专业领域问题。",
            "createUserId": 5905,
            "createTime": "2019-04-16T13:03:52.493",
            "updateTime": "2019-04-16T13:03:52.493",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": null,
            "logoText": "高级办公自动化\r\n（含视频）",
            "logoBackgroundColor": "rgb(160, 80, 0)",
            "isDel": false,
            "isBan": null,
            "status": 0,
            "ord": null,
            "pzycj": 0.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 0.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": false,
            "copyTimes": 0
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 1.2获取学生所参加的所有课程

[get]请求

```http
http://localhost:5000/api/Course/GetCourseByStudent?authtoken=&userId=29991
```

参数：

| 参数名    | 类型   | 是否可空 | 说明         |
| --------- | ------ | -------- | ------------ |
| authtoken | string | 否       | 登录证书     |
| userId    | int    | 否       | 学生的用户id |

返回：

| 字段    | 类型          | 说明                          |
| ------- | ------------- | ----------------------------- |
| retcode | int           | 返回码                        |
| info    | array[object] | （对应PE-Course表，字段同名） |
| id      | int           | 课程id                        |
| name    | string        | 课程名称                      |
| intro   | string        | 课程简介                      |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 562,
            "name": "大学计算机基础-周三班2019-2020-2",
            "teacher": 5906,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": "课程简介：“大学计算机基础”课程，32学时，2学分，通识课程（公选课），适合非计算机专业学生。主要内容：计算机基础与新一代信息技术简介；操作系统与因特网使用；办公自动化软件的高级运用。课程目标：掌握计算机科学与技术的基础知识、基本技能，提高学生应用计算机解决实际问题的能力。注重思维和素养培养，为学生的终生学习奠定基础，能够更好地使用计算机及相关技术来解决本专业领域问题。",
            "createUserId": 5905,
            "createTime": "2020-02-18T14:20:56.947",
            "updateTime": "2020-02-18T14:21:55.57",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": "",
            "logoText": "大学计算机基础-周三班2019-2020-2",
            "logoBackgroundColor": "rgb(27, 161, 226)",
            "isDel": false,
            "isBan": null,
            "status": 0,
            "ord": null,
            "pzycj": 0.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 0.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": true,
            "copyTimes": 0
        },
        {
            "id": 348,
            "name": "广厦学院测试",
            "teacher": 25086,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": null,
            "createUserId": 25086,
            "createTime": "2018-11-07T19:12:08.923",
            "updateTime": "2018-11-07T19:20:25.803",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": "",
            "logoText": "广厦学院测试",
            "logoBackgroundColor": "rgb(27, 161, 226)",
            "isDel": false,
            "isBan": null,
            "status": 0,
            "ord": null,
            "pzycj": 50.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 50.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": true,
            "copyTimes": 1
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "成功获取学生参与的所有课程信息"
}
```

#####  2.单个课程

```http
http://localhost:5000/api/Course/GetCourse?authtoken=&id=422
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       |        |
| id        | int    | 否       | 课程Id |

返回：

| 字段    | 类型          | 说明                          |
| ------- | ------------- | ----------------------------- |
| retcode | int           | 返回码                        |
| info    | array[object] | （对应PE-Course表，字段同名） |
| id      | int           | 课程id                        |
| name    | string        | 课程名称                      |
| intro   | string        | 课程简介                      |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 422,
            "name": "Java程序设计",
            "teacher": 31308,
            "teacher1": null,
            "teacher2": null,
            "teacher3": null,
            "intro": "<p>Java是一种简单的，面向对象的、分布式的、解释的、健壮的、可移植的、性能优异的多线程的动态语言。它经历了萌芽、发展和成熟阶段，现在已经成为 IT 领域里的主流编程语言，在众多领域得到广泛的应用。本课程以就业为导向，从高技能人才培养的要求出发，以强化技术应用能力培养为主线，构建理论教学体系和实践教学体系。</p>",
            "createUserId": 6045,
            "createTime": "2019-04-16T13:46:19.087",
            "updateTime": "2019-04-16T13:46:19.087",
            "moduleKownledge": false,
            "moduleResource": false,
            "moduleHomework": false,
            "moduleMutualJudge": false,
            "moduleExperiment": false,
            "moduleSimulation": false,
            "moduleDiscuss": false,
            "logo1": null,
            "logoText": "Java程序设计",
            "logoBackgroundColor": "rgb(27, 161, 226)",
            "isDel": false,
            "isBan": false,
            "status": 0,
            "ord": null,
            "pzycj": 0.0,
            "psycj": 0.0,
            "pkscj1": 0.0,
            "pkscj2": 0.0,
            "pkscj3": 0.0,
            "pkscj4": 0.0,
            "pkscj5": 0.0,
            "isAuthor": false,
            "copyTimes": 0
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```



#### 2.学生

##### 1.学生列表（搜索）

```http
http://localhost:5000/api/Users/StudentList?authtoken=&courseId=422&keyword&page=1&count=10
```

参数：

| 参数名    | 类型   | 是否可空 | 说明                                   |
| --------- | ------ | -------- | -------------------------------------- |
| authtoken | string | 否       | 令牌                                   |
| courseId  | int    | 否       | 课程Id（PE_CourseStudent中的CourseId） |
| keyword   | string | 是       | 关键字                                 |
| page      | int    | 否       | 页码                                   |
| count     | int    | 否       | 每页数量                               |

返回：

| 字段     | 类型          | 说明                          |
| -------- | ------------- | ----------------------------- |
| retcode  | int           | 返回码                        |
| info     | array[object] | PE_User数据表中对应的同名字段 |
| id       | int           | 学生id                        |
| userName | string        | 姓名                          |
| userNO   | string        | 学号                          |
| realName | string        | 姓名                          |
| sex      | string        | 性别                          |
| mobile   | string        | 手机号                        |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 20518,
            "userName": "2015210402004",
            "userNO": "2015210402004",
            "realName": "王懿琦",
            "sex": "",
            "userIdentity02": null,
            "mobile": null
        },
        {
            "id": 20519,
            "userName": "2015210402020",
            "userNO": "2015210402020",
            "realName": "王玲",
            "sex": "",
            "userIdentity02": null,
            "mobile": null
        },
        {
            "id": 20543,
            "userName": "2015210405064",
            "userNO": "2015210405064",
            "realName": "张伟芳",
            "sex": "",
            "userIdentity02": null,
            "mobile": null
        },
        {
            "id": 29686,
            "userName": "1",
            "userNO": "1",
            "realName": "1",
            "sex": "男",
            "userIdentity02": null,
            "mobile": "测试"
        },
        {
            "id": 29687,
            "userName": "2",
            "userNO": "2",
            "realName": "2",
            "sex": null,
            "userIdentity02": null,
            "mobile": null
        },
        {
            "id": 31312,
            "userName": "1008601",
            "userNO": null,
            "realName": "张三",
            "sex": "男",
            "userIdentity02": null,
            "mobile": null
        }
    ],
    "pagecount": 1,
    "recordcount": 6,
    "isfirst": true,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.学生详情

```http 
http://localhost:5000/api/Users/GetStudent?authtoken=&id=29687
```

参数：

| 参数名    | 类型   | 是否可空 | 说明                        |
| --------- | ------ | -------- | --------------------------- |
| authtoken | string | 否       | 令牌                        |
| id        | int    | 否       | 学生id（PE_User数据表中Id） |

返回:

| 字段           | 类型          | 说明    |
| -------------- | ------------- | ------- |
| retcode        | int           | 返回码  |
| info           | array[object] |         |
| id             | int           | id      |
| userName       | string        | 账号    |
| userNO         | string        | 学号    |
| realName       | string        | 姓名    |
| sex            | string        | 性别    |
| userIdentity02 | string        | 班级    |
| mobile         | string        | 电话    |
| userIdentity00 | string        | 学院/系 |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": 29687,
        "userName": "2",
        "userNO": "2",
        "realName": "2",
        "sex": null,
        "userIdentity02": null,
        "mobile": null,
        "userIdentity00":null
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2用户详情

[get]

```http 
http://localhost:5000/api/Users/GetUserByAuthtoken?authtoken=
```

参数：

| 参数名    | 类型   | 是否可空 | 说明 |      |
| --------- | ------ | -------- | ---- | ---- |
| authtoken | string | 否       | 令牌 |      |

返回:

| 参数名      | 类型   | 是否可空 | 备注                                    |
| ----------- | ------ | -------- | --------------------------------------- |
| retcode     | 返回码 | 否       | 说明见上                                |
| authtoken   | string | 是       | 用户登录标识（记录id）                  |
| info        | object | 是       | 返回数据(PE_User数据表中对应的同名字段) |
| pagecount   | int    | 是       | 总页码数                                |
| recordcount | int    | 是       | 数据总条数                              |
| isfirst     | bool   | 是       | 是否是第一页                            |
| hasnext     | bool   | 是       | 是否有下一页                            |
| items       | object | 是       |                                         |
| debug       | string | 是       | 调试信息                                |
| id          | int    | 是       | id                                      |
| message     | string | 是       | 返回信息                                |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": 31308,
        "userName": "chenyong",
        "userNO": "2018112011006",
        "password": "E10ADC3949BA59ABBE56E057F20F883E",
        "realName": "陈勇",
        "sex": "男",
        "brithday": "0001-01-01T00:00:00",
        "email": "10086@gmail",
        "mobile": "0571-28865731",
        "userIdentity00": null,
        "userIdentity01": "1",
        "userIdentity02": null,
        "userIdentity03": "2",
        "zip": null,
        "address": "杭州师范大学仓前校区",
        "avatar": null,
        "introduction": null,
        "property00": null,
        "property01": null,
        "property02": null,
        "property03": null,
        "property04": null,
        "property05": "10086",
        "property06": "641AA374F3CFB9FB28A9A2CBFFB9CA3F",
        "property07": null,
        "property08": null,
        "property09": null,
        "schoolId": "5453742274816630924",
        "school": null
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 

##### 2.添加学生

[post]

```http 
http://api/Users/AddCourseStudent?authtoken=&courseId=422
```

参数：

| 参数名         | 类型          | 是否可空 | 说明                                                        |
| -------------- | ------------- | -------- | ----------------------------------------------------------- |
| authtoken      | string        | 否       | 令牌                                                        |
| courseId       | int           | 否       | 课程id                                                      |
| addUser        | array[object] |          | 用username在PE_User中先判断用户是否存在，不存在则先添加用户 |
| userName       | string        | 否       | 账号                                                        |
| realName       | string        | 否       | 真实姓名                                                    |
| userIdentity00 | string        | 是       | 学院、系                                                    |
| property02     | string        | 是       | 班级                                                        |
| sex            | string        | 是       | 性别（男，女，默认男）                                      |
| mobile         | string        | 是       | 电话                                                        |

发送格式：Body+raw+Json

```json
{
	"userName":"2015210402020",
	"RealName":"王玲",
	"userIdentity00":"计算机153",
	"property02":"",
	"sex":"女",
	"mobile":""
}
```

返回:

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json 
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "学生关联到课程中成功"
}
```



##### 3.编辑学生

```http
http://api/Users/EditUser?authtoken=&id=35899
```

   [HttpPatch]

有关HttpPatch局部更新操作转下面的链接：

```json 
https://www.cnblogs.com/bijinshan/p/9140111.html
```

参数 params：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| id        | int    | 否       | 学生id |

Headers ：

| key          | value                       |
| ------------ | --------------------------- |
| Content-Type | application/json-patch+json |

Body: 

```json
[
	{
		"op":"replace",
		"path":"/userName",
		"value":"chenyong1"
	},
	{
		"op":"replace",
		"path":"/RealName",
		"value":"123"
	},
	{
		"op":"replace",
		"path":"/Password",
		"value":"E10ADC3949BA59ABBE56E057F20F883E"
	},
	{
		"op":"replace",
		"path":"/sex",
		"value":"男"
	},
	{
		"op":"add",
		"path":"/UserIdentity01",
		"value":"1"
	},
		{
		"op":"add",
		"path":"/UserIdentity03",
		"value":"1"
	}
]

```

返回:

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "修改成功"
}
```

##### 3.2编辑用户个人信息（参数userName必须要有）

```http
http://localhost:5000/api/Users/EditAdmin?authtoken=&id=1
```

   [HttpPost]（以后更新全部用post）

参数 params：

| 参数名    | 类型   | 是否可空 | 说明                     |
| --------- | ------ | -------- | ------------------------ |
| authtoken | string | 否       | 令牌                     |
| id        | int    | 否       | 学生id （PE_User中的id） |

Headers ：

| key          | value                     |
| ------------ | ------------------------- |
| Content-Type | application/Body+raw+Json |

Body: 

```json
{
    "userName": "yhj",
    "sex": "男",
    "mobile": "28865371",
    "email": "1033552@gmail",
    "address": "杭师大",
    "property05": "1033558982"
}

```

返回:

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "用户修改成功"
}
```



##### 4.删除学生

```http
http://api/Users/DeleteUser?authtoken=&id=
```

参数：

| 参数名    | 类型   | 是否可空 | 说明【软删除，将PE_User中对应用户的UserIdentity01设为0】 |
| --------- | ------ | -------- | -------------------------------------------------------- |
| authtoken | string | 否       | 令牌                                                     |
| id        | int    | 否       | 学生id（PE_User中的id）                                  |

返回:

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{
  "retcode" : 0
}
```



##### 5.重置密码

[get]

```http
http://api/Users/RetsetPwd?authtoken=&id
```

参数：

| 参数名    | 类型   | 是否可空 | 说明                    |
| --------- | ------ | -------- | ----------------------- |
| authtoken | string | 否       | 令牌                    |
| id        | int    | 否       | 学生id（PE_User中的id） |

返回：

```
{
  "retcode" : 0
}
```

##### 5.2 修改个人密码

[post]

```http
http://localhost:5000/api/Users/EditPwd?authtoken=&id=31308
```

参数：

| 参数名    | 类型   | 是否可空 | 说明                    |
| --------- | ------ | -------- | ----------------------- |
| authtoken | string | 否       | 令牌                    |
| id        | int    | 否       | 学生id（PE_User中的id） |

Headers ：

| key          | value                     |
| ------------ | ------------------------- |
| Content-Type | application/Body+raw+Json |

Body: 

```json
{
    "password": "123456"
}

```

返回:

```
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "密码修改成功"
}
```



#### 3.作业、实验、练习

##### 1. 列表（搜索）

```http
http://localhost:5000/api/Course/HomeWorkList?authtoken=&courseId=422&type=3&keyword&page=1&count=10
```

参数：

| 参数名    | 类型   | 是否可空 | 说明                    |
| --------- | ------ | -------- | ----------------------- |
| authtoken | string | 否       | 令牌                    |
| courseId  | int    | 否       | 课程id                  |
| type      | int    | 否       | 1考试 2练习 3作业 4实验 |
| keyword   | string | 是       | 关键字                  |
| page      | int    | 否       | 页码                    |
| count     | int    | 否       | 每页条数                |

返回：

| 字段        | 类型          | 说明     |
| ----------- | ------------- | -------- |
| retcode     | int           | 返回码   |
| info        | array[object] |          |
| id          | int           | 作业id   |
| name        | string        | 作业名称 |
| pagecount   |               |          |
| recordcount |               |          |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": "9828",
            "nid": "1fdd2f68d8fc883c",
            "name": "测试",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": "",
            "createUserId": 31308,
            "createTime": "2020-04-20T20:25:30.243",
            "startTime": "2020-04-20T00:00:00",
            "endTime": "2020-04-21T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": true,
            "keyVisible": true,
            "autoSubmitOnTimeLimit": false,
            "drawPlotId": 2710,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": null,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": 0,
            "scoreAppear": 1,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6676",
            "nid": "73fed0602562cb1e",
            "name": "Java程序设计-作业十二",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-12-14T00:00:00",
            "endTime": "2018-12-22T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2095,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6678",
            "nid": "d53660f85ca2db1e",
            "name": "Java程序设计-作业十一",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-12-07T00:00:00",
            "endTime": "2018-12-13T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2085,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6681",
            "nid": "27adec3f3f88af1e",
            "name": "Java程序设计-作业十",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-11-30T00:00:00",
            "endTime": "2018-12-05T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2055,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6682",
            "nid": "3e54754d19e34b1e",
            "name": "Java程序设计-作业九 ",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-11-22T00:00:00",
            "endTime": "2018-11-29T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2035,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6685",
            "nid": "c304e3f9dd02cb1e",
            "name": "Java程序设计-作业八",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-11-16T00:00:00",
            "endTime": "2018-11-22T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 2009,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6687",
            "nid": "18a90f31862cb1e",
            "name": "Java程序设计-作业七",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-11-02T00:00:00",
            "endTime": "2018-11-14T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1949,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6689",
            "nid": "eff935b78243cb1e",
            "name": "Java程序设计-作业六",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-10-19T00:00:00",
            "endTime": "2018-10-26T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1911,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6691",
            "nid": "933b7bd255decb1e",
            "name": "Java程序设计-作业五",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-10-11T00:00:00",
            "endTime": "2018-10-17T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1875,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        },
        {
            "id": "6694",
            "nid": "95ccda2b75515b1e",
            "name": "Java程序设计-作业四",
            "mode": 3,
            "isOpen": true,
            "timeLimit": 0,
            "retryTimes": 0,
            "memo": null,
            "createUserId": 31308,
            "createTime": "2019-04-16T13:46:19.243",
            "startTime": "2018-09-30T00:00:00",
            "endTime": "2018-10-11T23:59:00",
            "restTime": null,
            "lunchTime": null,
            "forbiddenCopy": true,
            "forbiddenMouseRightMenu": true,
            "enableClientJudge": false,
            "keyVisible": false,
            "autoSubmitOnTimeLimit": null,
            "drawPlotId": 1821,
            "testTemplateId": null,
            "courseId": 422,
            "enableMutualJudge": false,
            "mutualJudgeEndTime": null,
            "isMutualJudgeGroupingPublished": null,
            "timeMutualJudgeGroupingPublish": null,
            "mutualJudgeGroupingSize": null,
            "setScore": 100.0,
            "viewOneWithAnswerKey": false,
            "ord": null,
            "scoreAppear": null,
            "delayEndTime": null,
            "delayPercentOfScore": null,
            "ipallowAccessCheck": false
        }
    ],
    "pagecount": 2,
    "recordcount": 13,
    "isfirst": true,
    "hasnext": true,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2. 抽题策略

```http
http://localhost:5000/api/Course/DrawPlotList?authtoken=
```

参数：

| 参数名    | 类型   | 是否可空 | 说明         |
| --------- | ------ | -------- | ------------ |
| authtoken | string | 否       | 用户登录令牌 |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{
    "retcode": 0,
    "authtoken": "97F02636E249793AACC3EA72B75A5BE5510CBACC45C9E2D447392798BBDE50D6",
    "info": [
        {
            "id": 2399,
            "name": "C语言程序设计"
        },
        {
            "id": 2400,
            "name": "计算机基础手工组卷"
        },
        {
            "id": 2409,
            "name": "C语言手工组卷2"
        },
        {
            "id": 2410,
            "name": "C语言测试策略"
        },
        {
            "id": 2427,
            "name": "test"
        },
        {
            "id": 2437,
            "name": "new策略"
        },
        {
            "id": 2458,
            "name": "策略A"
        },
        {
            "id": 2459,
            "name": "new"
        },
        {
            "id": 2467,
            "name": "1"
        },
        {
            "id": 2484,
            "name": "new"
        },
        {
            "id": 2570,
            "name": "测试0729"
        },
        {
            "id": 2580,
            "name": "测试"
        },
        {
            "id": 2401,
            "name": "C语言知识点组卷"
        },
        {
            "id": 2583,
            "name": "test "
        },
        {
            "id": 2586,
            "name": "11"
        },
        {
            "id": 2710,
            "name": "测试"
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```



##### 3. 添加

[post]

```http
http://api/course/AddHomeWork?authtoken=&courseId=422&type=3
```

参数：

| 参数名                  | 类型          | 是否可空 | 说明                              |
| ----------------------- | ------------- | -------- | --------------------------------- |
| authtoken               | string        | 否       | 用户登录令牌                      |
| courseId                | int           | 否       | 课程id                            |
| type                    | int           | 否       | 1考试 ，2练习 ，3作业，4实验      |
| test                    | array[object] |          |                                   |
| name                    | string        | 否       | 名称                              |
| drawPlotId              | int           | 否       | 抽题策略Id                        |
| startTime               | DateTime      | 否       | 开始时间                          |
| endTime                 | DateTime      | 否       | 结束时间                          |
| delayEndTime            | DateTime      | 是       | 补交截止时间                      |
| delayPercentOfScore     | double        | 是       | 补交得分比例                      |
| memo                    | string        | 是       | 说明                              |
| enableMutualJudge       | bool          | 是       | 作业互评（默认0,不互评，1：互评） |
| mutualJudgeEndTime      | DateTime      | 是       | 互评截止时间                      |
| setScore                | double        | 否       | 分数展示                          |
| scoreAppear             | int           | 否       | 成绩展示                          |
| forbiddenCopy           | bool          | 是       | 禁止复制题目                      |
| forbiddenMouseRightMenu | bool          | 是       | 禁止右键                          |
| enableClientJudge       | bool          | 是       | 开启学生端阅卷                    |
| keyVisible              | bool          | 是       | 查卷时标准答案可见                |

发送格式：Body+raw+Json

```json
	{
		"name":"测试",
		"drawPlotId":2710,
		"startTime":"2020-04-20 00:00:00.000",
		"endTime":"2020-04-21 23:59:00.000",
		"delayEndTime":"",
		"delayPercentOfScore":"",
		"memo":"",
		"enableMutualJudge":"",
		"mutualJudgeEndTime":"",
		"setScore":100,
		"scoreAppear":1,
		"forbiddenCopy":1,
		"forbiddenMouseRightMenu":1,
		"enableClientJudge":1,
		"keyVisible":1,
	}
```

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "创建成功"
}
```

##### 4.获取单个作业，实验，练习详情

```http
http://localhost:5000/api/Course/HomeWork?authtoken=97F02636E249793A37CED81599713373CF32DF9495F10BDD397063C90385D876&id=9828
```

| 参数名    | 类型   | 是否可空 | 说明               |
| --------- | ------ | -------- | ------------------ |
| authtoken | string | 否       | 令牌               |
| id        | int    | 否       | 作业，实验，练习id |

返回：

| 字段                    | 类型          | 说明                          |
| ----------------------- | ------------- | ----------------------------- |
| retcode                 | int           | 返回码                        |
| info                    | array[object] |                               |
| id                      | int           | id                            |
| name                    | string        | 名称                          |
| mode                    | int           | 类型：1考试 2练习 3作业 4实验 |
| isOpen                  | bool          | 是否打开                      |
| timeLimit               | int           | 限时完成                      |
| retryTimes              | int           | 尝试次数                      |
| memo                    | string        | 说明                          |
| createUserId            | int           | 创建者Id                      |
| createTime              | dateTime      | 创建时间                      |
| startTime               | dateTime      | 开始时间                      |
| endTime                 | dateTime      | 结束时间                      |
| forbiddenCopy           | bool          | 禁止复制题目                  |
| forbiddenMouseRightMenu | bool          | 禁止右键                      |
| enableClientJudge       | bool          | 开启学生端阅卷                |
| keyVisible              | bool          | 学生端阅卷后标准答案可见      |
| drawPlotId              | int           | 策略Id                        |
| courseId                | int           | 课程Id                        |
| enableMutualJudge       | bool          | 作业互评                      |
| mutualJudgeEndTime      | dateTime      | 互评截止时间                  |
| setScore                | double        | 总分                          |
| viewOneWithAnswerKey    | bool          | 查卷时标准答案可见            |
| ord                     | int           | 排序                          |
| scoreAppear             | int           | 成绩展示：1展示，2不展示      |
| delayEndTime            | dateTime      | 补交截止时间                  |
| delayPercentOfScore     | double        | 补交得分比例                  |
| ipallowAccessCheck      | bool          | IP地址访问检查                |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": "9828",
        "name": "测试",
        "mode": 3,
        "isOpen": true,
        "timeLimit": 0,
        "retryTimes": 0,
        "memo": "",
        "createUserId": 31308,
        "createTime": "2020-04-20T20:25:30.243",
        "startTime": "2020-04-20T00:00:00",
        "endTime": "2020-04-21T23:59:00",
        "forbiddenCopy": true,
        "forbiddenMouseRightMenu": true,
        "enableClientJudge": true,
        "keyVisible": true,
        "drawPlotId": 2710,
        "courseId": 422,
        "enableMutualJudge": null,
        "mutualJudgeEndTime": null,
        "setScore": 100.0,
        "viewOneWithAnswerKey": false,
        "ord": 0,
        "scoreAppear": 1,
        "delayEndTime": null,
        "delayPercentOfScore": null,
        "ipallowAccessCheck": false
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```



##### 5. 编辑(详情)

[HttpPatch]

```http
http://localhost:5000/api/Course/EditHomeWork?authtoken=&id=6699
```

  参数 params：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| id        | int    | 否       | 作业id |

Headers ：

| key          | value                       |
| ------------ | --------------------------- |
| Content-Type | application/json-patch+json |

Body: 

```json
[
	{
		"op":"replace",
		"path":"/name",
		"value":"Java程序设计-作业一测试"
	},
	{
		"op":"replace",
		"path":"/EndTime",
		"value":"2019-12-22"
	},
    {
        ……
    }
]
```

 返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "修改成功"
}
```

##### 6. 删除

```http
http://localhost:5000/api/Course/DeleteWork?authtoken=&id=9827
```

参数：

| 参数名    | 类型   | 是否可空 | 说明 |
| --------- | ------ | -------- | ---- |
| authtoken | string | 否       | 令牌 |
| id        | int    | 否       | id   |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

#####  7. 批阅

获得带阅卷的学生作业，实验信息列表

```http 
http://localhost:5000/api/Course/JudgeList?authtoken=&testId=6699
```

参数：

| 参数名    | 类型   | 是否可空 | 说明               |
| --------- | ------ | -------- | ------------------ |
| authtoken | string | 否       | 令牌               |
| testId    | int    | 否       | 作业、实验、练习Id |

返回：

| 字段                | 类型          | 说明                     |
| ------------------- | ------------- | ------------------------ |
| retcode             | int           | 返回码                   |
| info                | array[object] |                          |
| id                  | int           | id                       |
| userTestNo          | string        | 学号                     |
| userTrueName        | string        | 学生姓名                 |
| logonIp             | string        | 登录IP                   |
| submitTime          | DateTime      | 提交时间（null：未交卷） |
| finishQuestionCount | int           | 答题数                   |
| totalScore          | double        | 总分                     |
| score               | double        | 得分                     |
| status              | bool          | 状态（是否阅卷）         |

```json
{  
 	retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 317220,
            "userTestNo": "2015210405064",
            "userTrueName": "张伟芳",
            "logonIp": "172.22.124.95",
            "submitTime": null,
            "finishQuestionCount": 0,
            "totalScore": 40.0,
            "score": 0.0,
            "status": true
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#### 4.课程资源

##### 1. 获取资源列表（搜索）

```http
http://localhost:5000/api/Course/ResourceList?authtoken=&courseId=422&parentId=0
```

参数：

| 参数名    | 类型   | 是否可空 | 说明             |
| --------- | ------ | -------- | ---------------- |
| authtoken | string | 否       | 令牌             |
| courseId  | int    | 否       | 课程id           |
| parentId  | int    | 否       | 资源父子关联标识 |
| keyword   | string | 是       | 关键字           |

返回：

| 字段       | 类型          | 说明         |
| ---------- | ------------- | ------------ |
| retcode    | int           | 返回码       |
| info       | array[object] |              |
| id         | int           | 文件id       |
| parentId   | int           | 父子关联标识 |
| fileName   | string        | 文件名       |
| fileIcon   | string        | 文件图标     |
| url        | string        | URL文件路径  |
| fileType   | string        | 文件类型     |
| size       | string        | 文件大小     |
| isDir      | bool          | 是否压缩     |
| isDel      | bool          | 是否删除     |
| isShared   | bool          | 是否共享     |
| createTime | string        | 文件创建日期 |
| userId     | int           | 创建者id     |
| password   | string        | 密码         |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 2174,
            "parentId": 0,
            "fileName": "WayBackIntoLove.mp3",
            "fileIcon": "music",
            "url": "~/Upload/resource/422/7a25ed6a-5be5-4df4-94a3-ab97006d1fab.mp3",
            "fileType": "mp3",
            "size": 11658607.0,
            "isDir": false,
            "isDel": false,
            "isShared": false,
            "createTime": "2020-04-08T14:37:18.473",
            "userId": 31308,
            "password": null
        },
        ……
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2. 上传文件（未做）

```http
http://api/upFile?authtoken=&courseId=1
```

参数：

| 参数名    | 类型          | 是否可空 | 说明         |
| --------- | ------------- | -------- | ------------ |
| authtoken | string        | 否       | 令牌         |
| courseId  | int           | 否       | 课程id       |
| fileData  | array[object] | 否       | 长传文件信息 |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 3. 删除资源

```http
http://api/Course/DeleteResource?authtoken=&id=1
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| id        | int    | 否       | 资源id |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 4.文件重命名

```http
http://api/Course/Rename?authtoken=&id=1961&name=
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| id        | int    | 否       | 资源id |
| name      | string | 否       | 重命名 |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0,
    "message" = "重命名成功"
}
```

#### 5.成绩

##### 1.作业,实验,考试成绩

先获取课程下的学生列表（见学生列表）方法，再根据学生id获取成绩

```http
http://localhost:5000/api/Course/ScoreInfo?authtoken=&courseId=422&type=3&userId=20518
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| courseId  | int    | 否       | 课程id |
| type      | int    | 否       | 类型   |
| userId    | int    | 否       | 学生id |

返回：

| 字段                 | 类型          | 说明   |
| -------------------- | ------------- | ------ |
| retcode              | int           | 返回码 |
| info                 | Array[object] |        |
| 作业，实验，考试名称 | 分数          |        |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "java程序设计-作业一": "0",
        "java程序设计-作业二": "0",
        "java程序设计-作业三": "0",
        "java程序设计-作业四": "0",
        "java程序设计-作业五": "0",
        "java程序设计-作业六": "0",
        "java程序设计-作业七": "0",
        "java程序设计-作业八": "0",
        "java程序设计-作业九 ": "0",
        "java程序设计-作业十": "0",
        "java程序设计-作业十一": "0",
        "java程序设计-作业十二": "0",
        "测试": "0"
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.成绩汇总

```http
http://localhost:5000/api/Course/StudentGrade?authtoken=&courseId=422&id=20518
```

先获取课程下的学生列表（见学生列表）方法，再根据学生id获取成绩汇总

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| courseId  | int    | 否       | 课程id |
| Id        | int    | 否       | 学生id |

返回：

| 字段       | 类型          | 说明      |
| ---------- | ------------- | --------- |
| retcode    | int           | 返回值    |
| info       | array[object] |           |
| courseId   | int           | 课程id    |
| userId     | int           | 学生id    |
| zycj       | double        | 作业成绩  |
| sycj       | double        | 实验成绩  |
| kscj1      | double        | 考试成绩1 |
| kscj2      | double        | 考试成绩2 |
| kscj3      | double        | 考试成绩3 |
| kscj4      | double        | 考试成绩4 |
| kscj5      | double        | 考试成绩5 |
| cj         | double        | 成绩      |
| finalGrade | double        | 最终成绩  |
| level      | string        | 等级      |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "courseId": 422,
            "userId": 20518,
            "zycj": 0.0,
            "sycj": 0.0,
            "kscj1": 0.0,
            "kscj2": 0.0,
            "kscj3": 0.0,
            "kscj4": 0.0,
            "kscj5": 0.0,
            "cj": 0.0,
            "course": null,
            "finalGrade": 0.0,
            "level": "缓考"
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#### 6.试卷打印

#####  1.打印考试列表（搜索）

```http
http://localhost:5000/api/Course/PaperTaskList?authtoken=&courseId=422&authtoken=&keyword
```

参数：

| 参数名    | 类型   | 是否可空 | 说明         |
| --------- | ------ | -------- | ------------ |
| authtoken | string | 否       | 令牌         |
| courseId  | int    | 否       | 课程id       |
| authtoken | string | 否       | 登录用户令牌 |
| keyword   | string | 否       | 关键字       |

返回：

| 字段        | 类型          | 说明     |
| ----------- | ------------- | -------- |
| retcode     | int           | 返回码   |
| info        | array[object] |          |
| id          | int           | id       |
| name        | string        | 名称     |
| totalCount  | int           | 试卷总数 |
| finishCount | int           | 完成数   |
| startTime   | string        | 开始时间 |
| finishTime  | DateTime      | 完成时间 |
| fileName    | string        | 文件名称 |
| filePath    | string        | 路径     |
| result      | string        | 状态     |
| message     | string        | 结果     |
| fileSize    | string        | 文件大小 |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 671,
            "name": "Java程序设计-作业十二试卷打印任务",
            "totalCount": 1,
            "finishCount": 1,
            "startTime": "2020-04-10T20:22:28.003",
            "finishTime": "2020-04-10T20:22:30.023",
            "fileName": "e4165150e8525c02.zip",
            "filePath": "E:\\webiste\\XTest\\output\\paper\\zip\\e4165150e8525c02.zip",
            "result": "成功",
            "message": null,
            "fileSize": "62.09 KB"
        },
        {
            "id": 669,
            "name": "Java程序设计-实验十试卷打印任务",
            "totalCount": 0,
            "finishCount": 0,
            "startTime": "2020-04-13T17:49:57.48",
            "finishTime": "2020-04-13T17:49:57.62",
            "fileName": "8933448d4d336044.zip",
            "filePath": "E:\\webiste\\XTest\\output\\paper\\zip\\8933448d4d336044.zip",
            "result": "成功",
            "message": "",
            "fileSize": "22.00 字节"
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.获取单个打印任务信息

```http
http://localhost:5000/api/Course/PaperTask?authtoken=97F02636E249793A37CED81599713373CF32DF9495F10BDD397063C90385D876&id=671
```

参数：

| 参数名    | 类型   | 是否可空 | 说明 |
| --------- | ------ | -------- | ---- |
| authtoken | string | 否       | 令牌 |
| id        | int    | 否       | id   |

返回：

| 字段        | 类型          | 说明     |
| ----------- | ------------- | -------- |
| retcode     | int           | 返回码   |
| info        | array[object] |          |
| id          | int           | id       |
| name        | string        | 名称     |
| totalCount  | int           | 试卷总数 |
| finishCount | int           | 完成数   |
| startTime   | string        | 开始时间 |
| finishTime  | DateTime      | 完成时间 |
| fileName    | string        | 文件名称 |
| filePath    | string        | 路径     |
| result      | string        | 状态     |
| message     | string        | 结果     |
| fileSize    | string        | 文件大小 |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": 671,
        "name": "Java程序设计-作业十二试卷打印任务",
        "totalCount": 1,
        "finishCount": 1,
        "startTime": "2020-04-10T20:22:28.003",
        "finishTime": "2020-04-10T20:22:30.023",
        "fileName": "e4165150e8525c02.zip",
        "filePath": "E:\\webiste\\XTest\\output\\paper\\zip\\e4165150e8525c02.zip",
        "result": "成功",
        "message": null,
        "fileSize": "62.09 KB"
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```



##### 3. 打印任务考试选项

```http
http://localhost:5000/api/Course/ChooseTest?authtoken=&courseId=422
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| courseId  | int    | 否       | 课程id |

返回：

| 字段    | 类型          | 说明   |
| ------- | ------------- | ------ |
| retcode | int           | 返回码 |
| info    | array[object] |        |
| id      | int           | id     |
| name    | string        | 名称   |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 9828,
            "name": "测试"
        },
        {
            "id": 6676,
            "name": "Java程序设计-作业十二"
        },
        {
            "id": 6678,
            "name": "Java程序设计-作业十一"
        },
        {
            "id": 6681,
            "name": "Java程序设计-作业十"
        },
        {
            "id": 6682,
            "name": "Java程序设计-作业九 "
        },
        {
            "id": 6685,
            "name": "Java程序设计-作业八"
        },
        {
            "id": 6687,
            "name": "Java程序设计-作业七"
        },
        {
            "id": 6689,
            "name": "Java程序设计-作业六"
        },
        {
            "id": 6691,
            "name": "Java程序设计-作业五"
        },
        {
            "id": 6694,
            "name": "Java程序设计-作业四"
        },
        {
            "id": 6695,
            "name": "Java程序设计-作业三"
        },
        {
            "id": 6697,
            "name": "Java程序设计-作业二"
        },
        {
            "id": 6699,
            "name": "Java程序设计-作业一测试"
        },
        {
            "id": 6677,
            "name": "Java程序设计-实验十二"
        },
        {
            "id": 6679,
            "name": "Java程序设计-实验十一"
        },
        {
            "id": 6680,
            "name": "Java程序设计-实验十"
        },
        {
            "id": 6683,
            "name": "Java程序设计-实验九"
        },
        {
            "id": 6684,
            "name": "Java程序设计-实验八"
        },
        {
            "id": 6686,
            "name": "Java程序设计-实验七"
        },
        {
            "id": 6688,
            "name": "Java程序设计-实验六"
        },
        {
            "id": 6690,
            "name": "Java程序设计-实验五"
        },
        {
            "id": 6692,
            "name": "Java程序设计-实验四"
        },
        {
            "id": 6693,
            "name": "Java程序设计-实验三"
        },
        {
            "id": 6696,
            "name": "Java程序设计-实验二"
        },
        {
            "id": 6698,
            "name": "Java程序设计-实验一"
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 4.添加打印任务

[post]

```http
http://localhost:5000/api/Course/AddPaperTask?courseId=422&authtoken=&testId=9828
```

| 参数名    | 类型          | 是否可空 | 说明               |
| --------- | ------------- | -------- | ------------------ |
| courseId  | int           | 否       | 课程Id             |
| authtoken | string        | 否       | 用户登录令牌       |
| testId    | int           | 否       | 打印任务考试选项Id |
| pePaper   | array[object] |          |                    |
| option2   | string        | 是       | 副标题             |

发送格式：Body+raw+Json

```json
{
	"option2":"test"
}
```

返回:

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "添加成功"
}
```



##### 5. 重启打印（未做）

```
http://api/resetPrint?id=1
```

参数：

| 参数名 | 类型 | 是否可空 | 说明       |
| ------ | ---- | -------- | ---------- |
| id     | int  | 否       | 打印试卷id |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json 
{
   "retcode":0
}
```

##### 6. 删除打印

```http
http://localhost:5000/api/Course/DeletePaperTask?authtoken=&id=1
```

参数：

| 参数名    | 类型   | 是否可空 | 说明       |
| --------- | ------ | -------- | ---------- |
| authtoken | string | 否       | 领牌       |
| id        | int    | 否       | 打印试卷id |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json 
{
   "retcode":0,
    "message":"删除成功"
}
```



#### 7.手工组卷

##### 1.手工组卷列表

```http
http://localhost:5000/api/DrawPlot/DrawPlotsList?authtoken=97F02636E249793A37CED81599713373CF32DF9495F10BDD397063C90385D876&createdUserId=31308
```

参数：

| 参数名        | 类型   | 是否可空 | 说明                       |
| ------------- | ------ | -------- | -------------------------- |
| authtoken     | string | 否       | 领牌                       |
| createdUserId | int    | 否       | 创建者id（当前登录用户id） |

返回：

| 字段    | 类型          | 说明   |
| ------- | ------------- | ------ |
| retcode | int           | 返回码 |
| info    | array[object] |        |

```
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 2400,
            "labId": 282,
            "dptype": "TestPaper",
            "name": "计算机基础手工组卷",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-17T13:55:25.327",
            "updateTime": "2019-04-17T13:55:25.327",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2409,
            "labId": 158,
            "dptype": "TestPaper",
            "name": "C语言手工组卷2",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-18T09:45:14.737",
            "updateTime": "2019-04-18T09:45:14.737",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2410,
            "labId": 420,
            "dptype": "TestPaper",
            "name": "C语言测试策略",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-18T16:21:04.387",
            "updateTime": "2019-04-18T16:21:04.387",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2427,
            "labId": 306,
            "dptype": "TestPaper",
            "name": "test",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-24T14:14:08.317",
            "updateTime": "2019-04-24T14:14:08.317",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2458,
            "labId": 158,
            "dptype": "TestPaper",
            "name": "策略A",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-29T16:07:39.827",
            "updateTime": "2019-04-29T16:07:39.827",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2459,
            "labId": 158,
            "dptype": "TestPaper",
            "name": "new",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-04-29T16:12:52.637",
            "updateTime": "2019-04-29T16:12:52.637",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2467,
            "labId": 420,
            "dptype": "TestPaper",
            "name": "1",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-05-06T12:24:57.143",
            "updateTime": "2019-05-06T12:24:57.143",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        },
        {
            "id": 2570,
            "labId": 158,
            "dptype": "TestPaper",
            "name": "测试0729",
            "memo": "",
            "createUserId": 31308,
            "createTime": "2019-07-29T13:23:52.92",
            "updateTime": "2019-07-29T13:23:52.92",
            "shared": 0,
            "isDel": false,
            "questionRandom": false,
            "settingObject": null,
            "cataId": 1,
            "ord": null,
            "diffPaperCount": null,
            "cata": null,
            "lab": null,
            "peDrawPlotOfBundle": null,
            "peDrawPlotOfKnowledge": null,
            "peDrawPlotOfTestPaper": null,
            "peDrawPlotShared": [],
            "peTest": [],
            "peUserTestPaper": []
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.题型列表

```http
http://localhost:5000/api/DrawPlot/TestPaperTopic?authtoken=&drawplotId=2570
```

参数：

| 参数名     | 类型   | 是否可空 | 说明       |
| ---------- | ------ | -------- | ---------- |
| authtoken  | string | 否       | 令牌       |
| drawplotId | int    | 否       | 手工组卷id |

返回：

| 参数名    | 类型   | 说明   |
| --------- | ------ | ------ |
| retcode   | 返回码 |        |
| authtoken | string |        |
| info      | object |        |
| name      | string | 题型   |
| topicId   | int    | 题型Id |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "name": "判断题",
            "topicId": 701
        },
        {
            "name": "选择题",
            "topicId": 702
        },
        {
            "name": "概念填空题",
            "topicId": 703
        },
        {
            "name": "程序填空题",
            "topicId": 704
        },
        {
            "name": "程序改错题",
            "topicId": 705
        },
        {
            "name": "程序设计题",
            "topicId": 706
        }
    ],
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 3.题目（按题型，难度搜索）

```http
http://localhost:5000/api/DrawPlot/QuestionList?authtoken=&labId=158&topicList=701&difficultyList=1&page=1&count=100
```

参数：

注意：参数topicList和difficultyList  可以不传值，默认查所有，一个题型（难度）对应一个Id，可以传一个id或者多个id，传多个id中间时用“，”（英文逗号）连接且最后一个id后面不要加“，”

列如：api/DrawPlot/QuestionList?labId=158&topicList=701，702&difficultyList=1，2，3，4,5&page=1&count=100

| 参数名         | 类型   | 是否可空 | 说明                                          |
| -------------- | ------ | -------- | --------------------------------------------- |
| authtoken      | string | 否       | 令牌                                          |
| labId          | int    | 否       | 策略Id                                        |
| topicList      | string | 是       | 题型（见上获取题型id的API）                   |
| difficultyList | string | 是       | 难度：1：简单 2：较简单 3：中等 4：较难 5：难 |
| page           | int    | 否       | 页码                                          |
| count          | int    | 否       | 数量                                          |

返回：

| 参数名            | 类型     | 说明               |
| ----------------- | -------- | ------------------ |
| retcode           | 返回码   |                    |
| authtoken         | string   |                    |
| info              | object   |                    |
| id                | int      | 题目id             |
| topicId           | int      | 策略id             |
| bundleRank        | int      | 题号               |
| questionFace      | string   | 题目               |
| score             | double   | 分数               |
| optionA           | string   | 选项A              |
| optionB           | string   | B                  |
| optionC           | string   | C                  |
| optionD           | string   | D                  |
| answerKey         | string   | 答案               |
| answerKeyExt      | string   | 解释               |
| defaultAnswer     | string   | 默认答案           |
| difficulty        | int      | 难度               |
| knowledge         | string   | 全部知识点         |
| ord               | int      | 题序               |
| isDel             | bool     | 是否删除           |
| maxTopKnowledgeId | int      | 顶级（子级）知识点 |
| pagecount         | int      | 总页数             |
| recordcount       | int      | 总数量             |
| isfirst           | bool     | 是否是第一页       |
| hasnext           | bool     | 是否有下一页       |
| items             | object   | 是                 |
| debug             | string   | 调试               |
| id                | int      | id                 |
| datetime          | datetime | 时间               |
| message           | string   | 返回信息           |

```json
{
    "retcode": 0,
    "authtoken": null,
     "info": [
        {
            "id": 43738,
            "labId": 158,
            "topicId": 701,
            "bundleRank": 1,
            "questionFace": "C语言规定可以在程序中由用户指定任意一个函数作为主函数，程序将从此开始执行。",
            "score": 1.0,
            "optionA": "正确",
            "optionB": "错误",
            "optionC": "",
            "optionD": "",
            "answerKey": "B",
            "answerKeyExt": null,
            "defaultAnswer": null,
            "difficulty": 2,
            "knowledge": "6:",
            "ord": 1,
            "isDel": false,
            "maxTopKnowledgeId": 826
        },
        {
            "id": 43739,
            "labId": 158,
            "topicId": 701,
            "bundleRank": 1,
            "questionFace": "程序执行的效率与数据的存储结构相关。",
            "score": 1.0,
            "optionA": "正确",
            "optionB": "错误",
            "optionC": "",
            "optionD": "",
            "answerKey": "A",
            "answerKeyExt": null,
            "defaultAnswer": null,
            "difficulty": 3,
            "knowledge": "6:",
            "ord": 2,
            "isDel": false,
            "maxTopKnowledgeId": 826
        },……
     ], 
    "pagecount": 7,
    "recordcount": 660,
    "isfirst": true,
    "hasnext": true,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}

```



 #### 8. 邮箱

##### 1.获取用户收到的信件

[get]请求

```http 
http://localhost:5000/api/Message/GetReceiveMessage?authtoken=&userId=31308
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |      |
| --------- | ------ | -------- | ------ | ---- |
| authtoken | string | 否       | 令牌   |      |
| userId    | int    | 否       | 用户id |      |

返回:

| 参数名      | 类型   | 是否可空 | 备注         |
| ----------- | ------ | -------- | ------------ |
| retcode     | 返回码 | 否       | 说明见上     |
| authtoken   | string | 是       | 用户登录标识 |
| info        | object | 是       | 收到的信件   |
| pagecount   | int    | 是       | 总页码数     |
| recordcount | int    | 是       | 数据总条数   |
| isfirst     | bool   | 是       | 是否是第一页 |
| hasnext     | bool   | 是       | 是否有下一页 |
| items       | object | 是       |              |
| debug       | string | 是       | 调试信息     |
| id          | int    | 是       | id           |
| message     | string | 是       | 返回信息     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 1342,
            "code": "1342",
            "sender": 29991,
            "subject": "测试2",
            "body": "123",
            "isImportant": false,
            "sendTime": "2020-06-09T10:02:19.25",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 1110,
            "code": "1110",
            "sender": 29992,
            "subject": "辅导费",
            "body": "地方",
            "isImportant": false,
            "sendTime": "2019-12-19T14:29:17.693",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 978,
            "code": "978",
            "sender": 20543,
            "subject": "附件测试",
            "body": "详情见附件",
            "isImportant": true,
            "sendTime": "2019-09-24T10:23:56.147",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 966,
            "code": "966",
            "sender": 20543,
            "subject": "2",
            "body": "2",
            "isImportant": false,
            "sendTime": "2019-09-23T14:04:42.203",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 965,
            "code": "965",
            "sender": 20543,
            "subject": "1",
            "body": "1",
            "isImportant": false,
            "sendTime": "2019-09-23T14:04:30.977",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 962,
            "code": "962",
            "sender": 20543,
            "subject": "主题的字数长度显示问题测试1234567890",
            "body": "测试：主题的字数长度显示问题测试1234567890",
            "isImportant": true,
            "sendTime": "2019-09-20T15:12:27.367",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 960,
            "code": "960",
            "sender": 20543,
            "subject": "测试",
            "body": "哈哈哈哈哈哈哈哈哈哈或哈哈哈哈哈哈哈哈哈哈或哈哈哈哈哈哈哈哈哈哈或哈哈哈哈哈哈哈哈哈哈或哈哈哈哈哈哈哈哈哈哈或吼吼吼吼吼吼吼吼吼&nbsp;&nbsp;",
            "isImportant": true,
            "sendTime": "2019-09-20T10:56:18.293",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 881,
            "code": "881",
            "sender": 20543,
            "subject": "测试",
            "body": "test",
            "isImportant": false,
            "sendTime": "2019-05-09T16:06:19.59",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 872,
            "code": "872",
            "sender": 20543,
            "subject": "测试",
            "body": "new测试",
            "isImportant": false,
            "sendTime": "2019-04-29T15:53:45.817",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 870,
            "code": "870",
            "sender": 20543,
            "subject": "222",
            "body": "测试",
            "isImportant": false,
            "sendTime": "2019-04-29T09:34:32.56",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 869,
            "code": "869",
            "sender": 20543,
            "subject": "1111",
            "body": "test",
            "isImportant": false,
            "sendTime": "2019-04-28T16:45:45.34",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 867,
            "code": "867",
            "sender": 20543,
            "subject": "测试",
            "body": "邮件未读提醒",
            "isImportant": false,
            "sendTime": "2019-04-28T14:34:05.243",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 863,
            "code": "863",
            "sender": 20543,
            "subject": "1",
            "body": "1",
            "isImportant": true,
            "sendTime": "2019-04-25T09:11:00.997",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 861,
            "code": "861",
            "sender": 20543,
            "subject": "测试",
            "body": "测试",
            "isImportant": true,
            "sendTime": "2019-04-23T11:30:16.267",
            "isDel": false,
            "isRecycle": false
        }
    ],
    "pagecount": 2,
    "recordcount": 14,
    "isfirst": true,
    "hasnext": true,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

##### 2.获取用户发出的信件

[get]请求

```http 
http://localhost:5000/api/Message/GetSendMessage?authtoken=&userId=31308
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |      |
| --------- | ------ | -------- | ------ | ---- |
| authtoken | string | 否       | 令牌   |      |
| userId    | int    | 否       | 用户id |      |

返回:

| 参数名      | 类型   | 是否可空 | 备注         |
| ----------- | ------ | -------- | ------------ |
| retcode     | 返回码 | 否       | 说明见上     |
| authtoken   | string | 是       | 用户登录标识 |
| info        | object | 是       | 发出的信件   |
| pagecount   | int    | 是       | 总页码数     |
| recordcount | int    | 是       | 数据总条数   |
| isfirst     | bool   | 是       | 是否是第一页 |
| hasnext     | bool   | 是       | 是否有下一页 |
| items       | object | 是       |              |
| debug       | string | 是       | 调试信息     |
| id          | int    | 是       | id           |
| message     | string | 是       | 返回信息     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 964,
            "code": "964",
            "sender": 31308,
            "subject": "12111",
            "body": "1111111111111111111111222222222",
            "isImportant": true,
            "sendTime": "2019-09-23T13:15:58.88",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 879,
            "code": "879",
            "sender": 31308,
            "subject": "测试",
            "body": "1",
            "isImportant": false,
            "sendTime": "2019-05-05T15:51:18.187",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 871,
            "code": "871",
            "sender": 31308,
            "subject": "测试",
            "body": "1111",
            "isImportant": false,
            "sendTime": "2019-04-29T15:50:37.007",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 865,
            "code": "865",
            "sender": 31308,
            "subject": "test",
            "body": "11111",
            "isImportant": false,
            "sendTime": "2019-04-26T09:44:40.14",
            "isDel": false,
            "isRecycle": false
        },
        {
            "id": 862,
            "code": "862",
            "sender": 31308,
            "subject": "test",
            "body": "测试",
            "isImportant": true,
            "sendTime": "2019-04-24T13:50:07.937",
            "isDel": false,
            "isRecycle": false
        }
    ],
    "pagecount": 1,
    "recordcount": 5,
    "isfirst": true,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#####  3.获取用户放在回收站中的收到信件 

[get]请求

```http 
http://localhost:5000/api/Message/GetRecycleMessage?authtoken=&userId=31308
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |      |
| --------- | ------ | -------- | ------ | ---- |
| authtoken | string | 否       | 令牌   |      |
| userId    | int    | 否       | 用户id |      |

返回:

| 参数名      | 类型   | 是否可空 | 备注           |
| ----------- | ------ | -------- | -------------- |
| retcode     | 返回码 | 否       | 说明见上       |
| authtoken   | string | 是       | 用户登录标识   |
| info        | object | 是       | 回收站中的信件 |
| pagecount   | int    | 是       | 总页码数       |
| recordcount | int    | 是       | 数据总条数     |
| isfirst     | bool   | 是       | 是否是第一页   |
| hasnext     | bool   | 是       | 是否有下一页   |
| items       | object | 是       |                |
| debug       | string | 是       | 调试信息       |
| id          | int    | 是       | id             |
| message     | string | 是       | 返回信息       |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 1341,
            "code": "1341",
            "sender": 29991,
            "subject": "测试",
            "body": "测试一下能否接收到",
            "isImportant": true,
            "sendTime": "2020-06-08T19:16:40.827",
            "isDel": false,
            "isRecycle": false
        }
    ],
    "pagecount": 1,
    "recordcount": 1,
    "isfirst": true,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#####  4.获取邮件id获取Message的信息

[get]请求

```http 
http://localhost:5000/api/Message/GetMessageById?authtoken=&id=1343
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| id        | int    | 否       | 邮件id |

返回:

| 参数名      | 类型   | 是否可空 | 备注           |
| ----------- | ------ | -------- | -------------- |
| retcode     | 返回码 | 否       | 说明见上       |
| authtoken   | string | 是       | 用户登录标识   |
| info        | object | 是       | 信件的具体信息 |
| pagecount   | int    | 是       | 总页码数       |
| recordcount | int    | 是       | 数据总条数     |
| isfirst     | bool   | 是       | 是否是第一页   |
| hasnext     | bool   | 是       | 是否有下一页   |
| items       | object | 是       |                |
| debug       | string | 是       | 调试信息       |
| id          | int    | 是       | id             |
| message     | string | 是       | 返回信息       |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": 1343,
        "code": "1343",
        "sender": 25262,
        "subject": "搜索",
        "body": "阿萨啊",
        "isImportant": false,
        "sendTime": "2020-06-09T16:30:50.24",
        "isDel": false,
        "isRecycle": false,
        "senderNavigation": null,
        "peMessageAttach": [],
        "peMessageReceive": []
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#####  5.获取邮件id获取MessageReceive的信息

[get]请求

```http 
http://localhost:5000/api/Message/GetMessageReceiveById?authtoken=&Id=1343
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| id        | int    | 否       | 邮件id |

返回:

| 参数名      | 类型   | 是否可空 | 备注              |
| ----------- | ------ | -------- | ----------------- |
| retcode     | 返回码 | 否       | 说明见上          |
| authtoken   | string | 是       | 用户登录标识      |
| info        | object | 是       | Receive的具体信息 |
| pagecount   | int    | 是       | 总页码数          |
| recordcount | int    | 是       | 数据总条数        |
| isfirst     | bool   | 是       | 是否是第一页      |
| hasnext     | bool   | 是       | 是否有下一页      |
| items       | object | 是       |                   |
| debug       | string | 是       | 调试信息          |
| id          | int    | 是       | id                |
| message     | string | 是       | 返回信息          |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "messageId": 1343,
        "receiver": 25263,
        "isReaded": true,
        "isDel": false,
        "isRecycle": false,
        "message": null,
        "receiverNavigation": null
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": null
}
```

#####  6.根据邮件id将MessageReceive放入回收站

[get]请求

```http 
http://localhost:5000/api/Message/DeleteMessagetoRecycle?authtoken=&id=1342
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| id        | int    | 否       | 邮件id |

返回:

| 参数名      | 类型   | 是否可空 | 备注         |
| ----------- | ------ | -------- | ------------ |
| retcode     | 返回码 | 否       | 说明见上     |
| authtoken   | string | 是       | 用户登录标识 |
| info        | object | 是       |              |
| pagecount   | int    | 是       | 总页码数     |
| recordcount | int    | 是       | 数据总条数   |
| isfirst     | bool   | 是       | 是否是第一页 |
| hasnext     | bool   | 是       | 是否有下一页 |
| items       | object | 是       |              |
| debug       | string | 是       | 调试信息     |
| id          | int    | 是       | id           |
| message     | string | 是       | 返回信息     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "邮件成功放入回收站"
}
```

#####  7.根据邮件id将MessageReceive彻底软删除

[get]请求

```http 
http://localhost:5000/api/Message/DeleteMessagetoEnd?authtoken=&id=1342
```

参数：

| 参数名    | 类型   | 是否可空 | 说明   |
| --------- | ------ | -------- | ------ |
| authtoken | string | 否       | 令牌   |
| id        | int    | 否       | 邮件id |

返回:

| 参数名      | 类型   | 是否可空 | 备注         |
| ----------- | ------ | -------- | ------------ |
| retcode     | 返回码 | 否       | 说明见上     |
| authtoken   | string | 是       | 用户登录标识 |
| info        | object | 是       |              |
| pagecount   | int    | 是       | 总页码数     |
| recordcount | int    | 是       | 数据总条数   |
| isfirst     | bool   | 是       | 是否是第一页 |
| hasnext     | bool   | 是       | 是否有下一页 |
| items       | object | 是       |              |
| debug       | string | 是       | 调试信息     |
| id          | int    | 是       | id           |
| message     | string | 是       | 返回信息     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "邮件成功彻底删除"
}
```

#####  8.根据邮件id将MessageReceive从回收站中移回到收件箱中       [get]请求

```http 
http://localhost:5000/api/Message/MessageBackReceive?authtoken=&id=1342
```

#####  9.根据邮件id将Message标为重要文件       [get]请求

```http 
http://localhost:5000/api/Message/MessageImportant?authtoken=&id=1342
```

#####  10.根据邮件id将Message标为不重要文件       [get]请求

```http 
http://localhost:5000/api/Message/MessageNoImportant?authtoken=&id=1342
```

##### 11.添加PeMessage邮件(添加的同时修改code和添加对应的receive，也就是说与get方法NewCodeAndAddPeMessageReceive联用)     【并返回新建的这个PeMessage数据】

##### [post]

```http 
http://localhost:5000/api/Message/AddMessage?authtoken=
```

参数：   发送格式：Body+raw+Json

```json
{
    "sender":31308, //发件人id
    "subject":"测试是否数据库存储",
    "body":"postman测试",
    "isImportant":false
}
```

返回:

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json 
{
    "retcode": 0,
    "authtoken": null,
    "info": {
        "id": 1355,
        "code": "1",
        "sender": 31308,
        "subject": "测试是否数据库存储3",
        "body": "postman测试3",
        "isImportant": false,
        "sendTime": "2020-06-12T20:27:03.9564602+08:00",
        "isDel": false,
        "isRecycle": false
    },
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "新增PeMessage邮件成功"
}
```

#####  12.添加PeMessage邮件后将code改为与id一致 并且 创建相对应的PeMessageReceive表数据

[get]请求

```http 
http://localhost:5000/api/Message/NewCodeAndAddPeMessageReceive?authtoken=&id=1351&userid=29991
```

参数：

| 参数名    | 类型   | 是否可空 | 说明                 |
| --------- | ------ | -------- | -------------------- |
| authtoken | string | 否       | 令牌                 |
| id        | int    | 否       | 邮件id（MessageId）  |
| userid    | int    | 否       | 收件人id（Receiver） |

返回:

| 参数名      | 类型   | 是否可空 | 备注         |
| ----------- | ------ | -------- | ------------ |
| retcode     | 返回码 | 否       | 说明见上     |
| authtoken   | string | 是       | 用户登录标识 |
| info        | object | 是       | 空           |
| pagecount   | int    | 是       | 总页码数     |
| recordcount | int    | 是       | 数据总条数   |
| isfirst     | bool   | 是       | 是否是第一页 |
| hasnext     | bool   | 是       | 是否有下一页 |
| items       | object | 是       |              |
| debug       | string | 是       | 调试信息     |
| id          | int    | 是       | id           |
| message     | string | 是       | 返回信息     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": null,
    "pagecount": 0,
    "recordcount": 0,
    "isfirst": false,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "该邮件的code已经与邮件id一致,并且相对应的PeMessageReceive表数据建立"
}
```

#####  13.根据邮件id将邮件设为已读       [get]请求

```http 
http://localhost:5000/api/Message/MessageHasReaded?authtoken=&id=1351
```

#####  14.根据邮件id将发送的邮件软删除，PeMessage中的isDel=1       [get]请求

```http 
http://localhost:5000/api/Message/DeleteMessageHasSend?authtoken=&id=1351
```

#####  15.根据关键字和班级获取通讯录名单（用户名或真实名包含关键字的 【有效账户中老师和同班的人】）

?     如果关键字和班级都是空的话就只有所有现有老师               

 [get]请求 

```http 
http://localhost:5000/api/Message/GetTongxunlu?authtoken=&keyword=黄&property00=软工16
```

参数：

| 参数名     | 类型   | 是否可空 | 说明         |
| ---------- | ------ | -------- | ------------ |
| authtoken  | string | 否       | 令牌         |
| keyword    | string | 是       | 搜索的关键字 |
| property00 | string | 是       | 所在的班级   |

返回:

| 参数名      | 类型   | 是否可空 | 备注         |
| ----------- | ------ | -------- | ------------ |
| retcode     | 返回码 | 否       | 说明见上     |
| authtoken   | string | 是       | 用户登录标识 |
| info        | object | 是       | 搜索到的人   |
| pagecount   | int    | 是       | 总页码数     |
| recordcount | int    | 是       | 数据总条数   |
| isfirst     | bool   | 是       | 是否是第一页 |
| hasnext     | bool   | 是       | 是否有下一页 |
| items       | object | 是       |              |
| debug       | string | 是       | 调试信息     |
| id          | int    | 是       | id           |
| message     | string | 是       | 返回信息     |

```json
{
    "retcode": 0,
    "authtoken": null,
    "info": [
        {
            "id": 23201,
            "userName": "hyf123",
            "userNO": null,
            "password": "E10ADC3949BA59ABBE56E057F20F883E",
            "realName": "黄玉峰",
            "sex": null,
            "brithday": "0001-01-01T00:00:00",
            "email": null,
            "mobile": null,
            "userIdentity00": null,
            "userIdentity01": "1",
            "userIdentity02": null,
            "userIdentity03": "2",
            "zip": null,
            "address": null,
            "avatar": null,
            "introduction": null,
            "property00": null,
            "property01": null,
            "property02": null,
            "property03": null,
            "property04": null,
            "property05": null,
            "property06": null,
            "property07": null,
            "property08": null,
            "property09": null,
            "schoolId": null,
            "school": null
        },
        {
            "id": 24783,
            "userName": "hangrui",
            "userNO": null,
            "password": "E10ADC3949BA59ABBE56E057F20F883E",
            "realName": "黄锐",
            "sex": null,
            "brithday": "0001-01-01T00:00:00",
            "email": null,
            "mobile": null,
            "userIdentity00": null,
            "userIdentity01": "1",
            "userIdentity02": null,
            "userIdentity03": "2",
            "zip": null,
            "address": null,
            "avatar": null,
            "introduction": null,
            "property00": null,
            "property01": null,
            "property02": null,
            "property03": null,
            "property04": null,
            "property05": null,
            "property06": "CC6EA763B557E16CD7AFAC3DE40C560C2F524AF1A838C517",
            "property07": null,
            "property08": null,
            "property09": null,
            "schoolId": null,
            "school": null
        }
    ],
    "pagecount": 1,
    "recordcount": 2,
    "isfirst": true,
    "hasnext": false,
    "items": [],
    "debug": null,
    "id": 0,
    "datetime": null,
    "message": "获得了所有可用老师的信息"
}
```

#####  16.根据具体PeMessage的id和需要改变的code的值来将对应的PeMessage的code值改变

[get]请求

```http 
http://localhost:5000/api/Message/ChangeCode?authtoken=&id=1363&code=1362/1363
```

参数：

| 参数名    | 类型   | 是否可空 | 说明                |
| --------- | ------ | -------- | ------------------- |
| authtoken | string | 否       | 令牌                |
| id        | int    | 否       | 邮件id（MessageId） |
| code      | int    | 否       | 改变后的code值      |