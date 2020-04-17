

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

测试工具：postman，默认请求方式：get

### 1.登录

```http 
http://api/Login/Login?username=&password=
```

参数：

| 参数名   | 类型   | 是否可空 | 备注 |
| -------- | ------ | -------- | ---- |
| username | string | 否       | 账号 |
| password | string | 否       | 密码 |

返回：

| 字段      | 类型          | 说明     |
| --------- | ------------- | -------- |
| retcode   | int           | 返回码   |
| authtoken | string        | 登录证书 |
| info      | array[object] |          |
| type      | int           | 用户类型 |
| id        | int           | 用户id   |
| name      | string        | 姓名     |
| gender    | int           | 性别     |
| phone     | string        | 手机号   |
| imgurl    | string        | 头像路径 |

```json
{
    "retcode" : 0,
    "authtoken" : "3wfsf2323r2342112",
    "info" : {
        "type" : 0,
        "name" :"张三",
        "gender" :0,
        "phone" : "13708187211",
        "imgurl" : "图片路径"
    }
}
```



### 2.课程

#### 1.获取课程列表

```
http://api/getCourse?authtoken
```

参数：

| 参数名    | 类型   | 是否可空 | 说明     |
| --------- | ------ | -------- | -------- |
| authtoken | string | 否       | 登录证书 |

返回：

| 字段       | 类型          | 说明     |
| ---------- | ------------- | -------- |
| retcode    | int           | 返回码   |
| courseinfo | array[object] |          |
| id         | int           | 课程id   |
| name       | string        | 课程名称 |
| intro      | string        | 课程简介 |
| logo       | string        | 课程图标 |

```json
{
  "retcode" : 0,
  "courseinfo": [
     {
        "id":1,
        name:"angular",
        intro:"angulat简介……",
        logo:"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
  	 },
      {
        "id":2,
        name:"vue",
        intro:"vue简介……",
        logo:"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
  	 },
      ……
  ]
}
```



#### 2.学生列表

```
http://api/getStudentList?courseId=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明   |
| -------- | ---- | -------- | ------ |
| courseId | int  | 否       | 课程Id |

返回：

| 字段        | 类型          | 说明     |
| ----------- | ------------- | -------- |
| retcode     | int           | 返回码   |
| studentList | array[object] |          |
| id          | int           | 学生id   |
| name        | string        | 学生姓名 |
| img         | string        | 学生头像 |

```json
{
    "retcode":0,
	"studentList"：[
        {
           "id":"1",
           "name":"张三",
           "img":"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
        },
        {
           "id":"2",
           "name":"李四",
           "img":"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
        },
        ……
	]
}
```

##### 1.学生详情

```
http://api/getStudentInfo?id=1
```

参数：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| id     | int  | 否       | 学生id |

返回:

| 字段        | 类型          | 说明             |
| ----------- | ------------- | ---------------- |
| retcode     | int           | 返回码           |
| studentInfo | array[object] |                  |
| number      | int           | 学号             |
| name        | string        | 姓名             |
| college     | string        | 学院、系         |
| class       | string        | 班级             |
| gender      | int           | 性别（0男，1女） |
| phone       | string        | 电话             |

```json
{
    "retcode" : 0, 
	"studentInfo":{
		"number":"001",
		"name":"张三",
		"college":"信息技术",
		"class":"一班",
		"gender":"0",
		"phone":"18896761234"
	}
}
```

##### 2.添加学生

[post]

```http 
http://api/Users/AddCourseStudent?courseId=422
```

参数：

| 参数名         | 类型          | 是否可空 | 说明                   |
| -------------- | ------------- | -------- | ---------------------- |
| courseId       | int           | 否       | 课程id                 |
| addUser        | array[object] |          |                        |
| userName       | string        | 否       | 账号                   |
| realName       | string        | 否       | 真实姓名               |
| userIdentity00 | string        | 是       | 学院、系               |
| property02     | string        | 是       | 班级                   |
| sex            | string        | 是       | 性别（男，女，默认男） |
| mobile         | string        | 是       | 电话                   |

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
http://api/Users/EditUser?id=35899
```

   [HttpPatch]

有关HttpPatch局部更新操作转下面的链接：

```json 
https://www.cnblogs.com/bijinshan/p/9140111.html
```

参数 params：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| id     | int  | 否       | 学生id |

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



##### 4.删除学生

```
http://api/deleteStudent?id=1
```

参数：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| id     | int  | 否       | 学生id |

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

```
http://api/resetPwd?id
```

参数：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| id     | int  | 否       | 学生id |

返回：

```
{
  "retcode" : 0
}
```



##### 6.搜索学生

```
http://api/search?keywords
```

参数：

| 参数名   | 类型   | 是否可空 | 说明       |
| -------- | ------ | -------- | ---------- |
| keywords | string | 是       | 搜索关键字 |

返回：

| 字段        | 类型          | 说明     |
| ----------- | ------------- | -------- |
| retcode     | int           | 返回码   |
| studentList | array[object] |          |
| id          | int           | 学生id   |
| name        | string        | 学生姓名 |
| img         | string        | 学生头像 |

```json
{
  "retcode" : 0,
  "studentList"：[
        {
           "id":"1",
           "name":"张三",
           "img":"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
        },
        {
           "id":"2",
           "name":"李四",
           "img":"https://csfdasfkdfwe.wewe.com/wewesdf.jpg"
        },
        ……
	]
}
```



#### 3.作业列表

```
http://api/getWorktList?courseId=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明   |
| -------- | ---- | -------- | ------ |
| courseId | int  | 否       | 课程id |

返回：

| 字段     | 类型          | 说明     |
| -------- | ------------- | -------- |
| workinfo | array[object] |          |
| id       | int           | 作业id   |
| name     | string        | 作业名称 |

```json
{
  "workinfo": [
      {
         "id":1,
         "name":"作业1"
  	 },
       {
         "id":2,
         "name":"作业2"
  	 },
      ……
  ]
}
```

##### 1. 添加作业

```
http://api/addWork?courseId=1&workinfo=
```

参数：

| 参数名               | 类型          | 是否可空 | 说明                              |
| -------------------- | ------------- | -------- | --------------------------------- |
| courseId             | int           | 否       | 课程id                            |
| workinfo             | array[object] | 否       |                                   |
| name                 | string        | 否       | 作业名称                          |
| tactics              | string        | 否       | 抽题策略                          |
| startTime            | string        | 否       | 开始时间yyyyMMddHHmmss            |
| endTime              | string        | 否       | 结束时间yyyyMMddHHmmss            |
| addTime              | string        | 否       | 补交截止时间yyyyMMddHHmmss        |
| score                | int           | 否       | 总分                              |
| flag                 | int           | 是       | 作业互评（默认0,不互评，1：互评） |
| flagTime             | string        | 是       | 互评截止时间                      |
| showGrade            | bool          | 否       | 分数展示                          |
| parRadioList         | array         | 否       | 参数列表                          |
| forbidCopy           | bool          | 否       | 禁止复制题目（默认false）         |
| forbidRightClick     | bool          | 否       | 禁止右键（默认false）             |
| enableClientJudge    | bool          | 否       | 开启学生端阅卷（默认false）       |
| viewOneWithAnswerKey | bool          | 否       | 查卷时标准答案可见（默认false）   |

数据格式：json

```json
{
    "workinfo":[
        {
            "name":"作业名称",
            "tictics":"抽题策略",
            "startTime":"开始时间",
            "endTime":"结束时间",
            "addTime":"补交时间",
            "scroe":"总分",
            "flag":"0",
            "flagTime":"互评截止时间",
            "showGrade":"false",
            "parRadioList":[
               {
                 "forbidCopy":"false",
                 "forbidCopy" : "false",
            	 "enableClientJudge" : "true",
            	 "viewOneWithAnswerKey" : "false"
               }
            ]
        }
    ]
}
```

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 2. 编辑作业(详情)

```
http://api/editWork?workId=1
```

参数：

| 参数名               | 类型          | 是否可空 | 说明                              |
| -------------------- | ------------- | -------- | --------------------------------- |
| workId               | int           | 否       | 作业id                            |
| workinfo             | array[object] | 否       |                                   |
| name                 | string        | 否       | 作业名称                          |
| tactics              | string        | 否       | 抽题策略                          |
| startTime            | string        | 否       | 开始日期yyyyMMddHHmmss            |
| endTime              | string        | 否       | 结束时间yyyyMMddHHmmss            |
| addTime              | string        | 否       | 补交截止时间yyyyMMddHHmmss        |
| score                | int           | 否       | 总分                              |
| flag                 | int           | 是       | 作业互评（默认0,不互评，1：互评） |
| flagTime             | string        | 是       | 互评截止时间                      |
| showGradeList        | int           | 否       | 分数展示                          |
| parRadioList         | array         | 否       | 参数列表                          |
| forbidCopy           | bool          | 否       | 禁止复制题目（默认false）         |
| forbidRightClick     | bool          | 否       | 禁止右键（默认false）             |
| enableClientJudge    | bool          | 否       | 开启学生端阅卷（默认false）       |
| viewOneWithAnswerKey | bool          | 否       | 查卷时标准答案可见（默认false）   |

数据格式：json

```json
{
    "workinfo":[
        {
            "name":"作业名称",
            "tictics":"抽题策略",
            "startTime":"开始时间",
            "endTime":"结束时间",
            "addTime":"补交时间",
            "scroe":"总分",
            "flag":"0",
            "flagTime":"互评截止时间",
            "showGrade":"false",
            "parRadioList":[
               {
                 "forbidCopy":"false",
                 "forbidCopy" : "false",
            	 "enableClientJudge" : "true",
            	 "viewOneWithAnswerKey" : "false"
               }
            ]
        }
    ]
}
```

 返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 3. 删除作业

```
http://api/deleteWork?workId=1
```

参数：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| workId | int  | 否       | 课程id |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

#####  4. 作业批阅

```
http://api/readWork?workId=1
```

参数：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| workId | int  | 否       | 课程id |

返回：

```json
{  
 	"retcode" : 0
}
```

#### 4.实验列表

```
http://api/getLabtList?courseId=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明   |
| -------- | ---- | -------- | ------ |
| courseId | int  | 否       | 课程id |

返回：

| 字段    | 类型          | 说明     |
| ------- | ------------- | -------- |
|         | int           | 返回码   |
| labinfo | array[object] |          |
| id      | int           | 作业id   |
| name    | string        | 作业名称 |

```json
{
  "retcode":0,
  "labinfo": [
      {
         "id":1,
         "name":"实验1"
  	 },
       {
         "id":2,
         "name":"实验2"
  	 },
      ……
  ]
}
```

##### 1. 添加实验

```
http://api/addLab?courseId=1&labinfo
```

参数：

| 参数名               | 类型          | 是否可空 | 说明                            |
| -------------------- | ------------- | -------- | ------------------------------- |
| courseId             | int           | 否       | 课程id                          |
| labinfo              | array[object] | 否       |                                 |
| name                 | string        | 否       | 实验名称                        |
| tactics              | string        | 否       | 抽题策略                        |
| startTime            | string        | 否       | 开始日期yyyyMMddHHmmss          |
| endTime              | string        | 否       | 结束时间yyyyMMddHHmmss          |
| addTime              | string        | 否       | 补交截止时间yyyyMMddHHmmss      |
| score                | int           | 否       | 总分                            |
| flag                 | int           | 是       | 互评（默认0,不互评，1：互评）   |
| flagTime             | string        | 是       | 互评截止时间                    |
| showGradeList        | int           | 否       | 分数展示                        |
| parRadioList         | array         | 否       | 参数列表                        |
| forbidCopy           | bool          | 否       | 禁止复制题目（默认false）       |
| forbidRightClick     | bool          | 否       | 禁止右键（默认false）           |
| enableClientJudge    | bool          | 否       | 开启学生端阅卷（默认false）     |
| viewOneWithAnswerKey | bool          | 否       | 查卷时标准答案可见（默认false） |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 2. 编辑实验

```
http://api/editLab?LabId=1&labinfo
```

参数：

| 参数名               | 类型          | 是否可空 | 说明                            |
| -------------------- | ------------- | -------- | ------------------------------- |
| LabId                | int           | 否       | 实验id                          |
| labinfo              | array[object] | 否       |                                 |
| name                 | string        | 否       | 实验名称                        |
| tactics              | string        | 否       | 抽题策略                        |
| startTime            | string        | 否       | 开始日期yyyyMMddHHmmss          |
| endTime              | string        | 否       | 结束时间yyyyMMddHHmmss          |
| addTime              | string        | 否       | 补交截止时间yyyyMMddHHmmss      |
| score                | int           | 否       | 总分                            |
| flag                 | int           | 是       | 互评（默认0,不互评，1：互评）   |
| flagTime             | string        | 是       | 互评截止时间                    |
| showGradeList        | int           | 否       | 分数展示                        |
| parRadioList         | array         | 否       | 参数列表                        |
| forbidCopy           | bool          | 否       | 禁止复制题目（默认false）       |
| forbidRightClick     | bool          | 否       | 禁止右键（默认false）           |
| enableClientJudge    | bool          | 否       | 开启学生端阅卷（默认false）     |
| viewOneWithAnswerKey | bool          | 否       | 查卷时标准答案可见（默认false） |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 3. 删除实验

```
http://api/deleteLab?labId=1
```

参数：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| labId  | int  | 否       | 实验id |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 4. 批阅实验

```
http://api/readLab?labId=1
```

参数：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| labId  | int  | 否       | 实验id |

返回：

```json
{  
 	"retcode" : 0
}
```

#### 5.练习列表

```
http://api/getExerciseList?courseId=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明   |
| -------- | ---- | -------- | ------ |
| courseId | int  | 否       | 课程id |

返回：

| 字段         | 类型          | 说明     |
| ------------ | ------------- | -------- |
| exerciseinfo | array[object] |          |
| id           | int           | 练习id   |
| name         | string        | 练习名称 |

```json
{
  "exerciseinfo": [
      {
         "id":1,
         "name":"练习1"
  	 },
       {
         "id":2,
         "name":"练习2"
  	 },
      ……
  ]
}
```

##### 1. 添加练习

```
http://api/addExercise?courseId=1
```

参数：

| 参数名       | 类型          | 是否可空 | 说明                   |
| ------------ | ------------- | -------- | ---------------------- |
| courseId     | int           | 否       | 课程id                 |
| exerciseinfo | array[object] | 否       |                        |
| name         | string        | 否       | 练习名称               |
| tactics      | string        | 否       | 抽题策略               |
| startTime    | string        | 否       | 开始日期yyyyMMddHHmmss |
| endTime      | string        | 否       | 结束时间yyyyMMddHHmmss |
| parRadioList | array         | 是       | 参数列表               |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 2. 编辑练习

```
http://api/deleteExercise?exerciseId=1
```

参数：

| 参数名       | 类型          | 是否可空 | 说明                   |
| ------------ | ------------- | -------- | ---------------------- |
| exerciseId   | int           | 否       | 练习id                 |
| exerciseinfo | array[object] | 否       |                        |
| name         | string        | 否       | 练习名称               |
| tactics      | string        | 否       | 抽题策略               |
| startTime    | string        | 否       | 开始日期yyyyMMddHHmmss |
| endTime      | string        | 否       | 结束时间yyyyMMddHHmmss |
| parRadioList | array         | 是       | 参数列表               |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 3. 删除练习

```
http://api/deleteExercise?exerciseId=1
```

参数：

| 参数名     | 类型 | 是否可空 | 说明   |
| ---------- | ---- | -------- | ------ |
| exerciseId | int  | 否       | 练习id |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

#### 6.课程资源

##### 1. 获取资源列表

```
http://api/getResource/courseId=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明   |
| -------- | ---- | -------- | ------ |
| courseId | int  | 否       | 课程id |

返回：

| 字段         | 类型          | 说明         |
| ------------ | ------------- | ------------ |
| retcode      | int           | 返回码       |
| resourceList | array[object] |              |
| fileId       | int           | 文件id       |
| fileName     | string        | 文件名       |
| fileSize     | float         | 文件大小     |
| fileType     | string        | 文件类型     |
| fileUrl      | string        | 文件路径     |
| createdDate  | string        | 文件创建日期 |

```json
{  
 	"retcode" : 0,
    "resourceList":[
        {
            "fileId":1,
            "fileName":"文件夹1",
            "fileSize":"100",
            "fileType":"文件类型",
            "fileUrl":"文件路径",
            "createdDate":"yyyyMMddHHmmss"
        },
        {
            "fileId":2,
            "fileName":"文件夹1",
            "fileSize":"100",
            "fileType":"文件类型",
            "fileUrl":"文件路径",
            "createdDate":"yyyyMMddHHmmss"
        },
        ……
    ]
}
```

##### 2. 上传文件

```
http://api/upFile?courseId=1
```

参数：

| 参数名   | 类型          | 是否可空 | 说明         |
| -------- | ------------- | -------- | ------------ |
| courseId | int           | 否       | 课程id       |
| fileData | array[object] | 否       | 长传文件信息 |

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

```
http://api/deleteFile/id=1
```

参数：

| 参数名 | 类型 | 是否可空 | 说明   |
| ------ | ---- | -------- | ------ |
| id     | int  | 否       | 资源id |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

```json
{  
 	"retcode" : 0
}
```

##### 4. 搜索资源

```
http://api/searchFile?keywords
```

参数：

| 参数名   | 类型   | 是否可空 | 说明   |
| -------- | ------ | -------- | ------ |
| keywords | string | 是       | 关键词 |

返回：

| 字段         | 类型          | 说明         |
| ------------ | ------------- | ------------ |
| retcode      | int           | 返回码       |
| resourceList | array[object] |              |
| fileId       | int           | 文件id       |
| fileName     | string        | 文件名       |
| fileSize     | float         | 文件大小     |
| fileType     | string        | 文件类型     |
| fileUrl      | string        | 文件路径     |
| createdDate  | string        | 文件创建日期 |

```json
{  
 	"retcode" : 0,
    "resourceList":[
        {
            "fileId":1,
            "fileName":"文件夹1",
            "fileSize":"100",
            "fileType":"文件类型",
            "fileUrl":"文件路径",
            "createdDate":"yyyyMMddHHmmss"
        },
        {
            "fileId":2,
            "fileName":"文件夹1",
            "fileSize":"100",
            "fileType":"文件类型",
            "fileUrl":"文件路径",
            "createdDate":"yyyyMMddHHmmss"
        },
        ……
    ]
}
```

#### 7.作业成绩

```
http://api/workGradeList?courseId=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明             |
| -------- | ---- | -------- | ---------------- |
| courseId | int  | 否       | 课程id           |
| count    | int  | 是       | 每页记录数量     |
| page     | int  | 是       | 第几页， 从1开始 |

返回：

| 字段        | 类型          | 说明           |
| ----------- | ------------- | -------------- |
| retcode     | int           | 返回码         |
| pagecount   | int           | 数据总共有几页 |
| recordcount | int           | 总共记录数     |
| isfirst     | bool          | 是否是第一页   |
| hasnext     | bool          | 是否还有下一页 |
| studentInfo | array[object] |                |
| studentId   | int           | 学生id         |
| studentName | string        | 学生姓名       |

```json
{
   "retcode":0,
    "pagecount" : 1, 
    "recordcount" : 1, 
    "isfirst" : false, 
    "hasnext" : true, 
    "studentInfo":[
    	{
    	  "studentId":1,
    	  "studentName":"张三",
    	},
    	{
    	  "studentId":2,
    	  "studentName":"李四",
    	},
    	……
    ]
}
```

##### 1. 获取单个学生成绩

```
http://api/workGrade?studnetId=1&courseId=1
```

参数：

| 参数名    | 类型 | 是否可空 | 说明   |
| --------- | ---- | -------- | ------ |
| studnetId | int  | 否       | 学生id |
| courseId  | int  | 否       | 课程id |

返回：

| 字段      | 类型          | 说明                 |
| --------- | ------------- | -------------------- |
| retcode   | int           | 返回值               |
| name      | string        | 学生姓名             |
| class     | string        | 班级                 |
| gender    | int           | 性别（默认0男，女1） |
| gradeList | array[object] |                      |
| workName  | string        | 作业名称             |
| grade     | float         | 成绩                 |

```json
{
  "retcode":0,
  "name":"姓名",
  "class":"班级",
  "gender":"性别",
  "gradeList":[
   	  {
   		"workName":"作业1",
   		"grade":"100"
   	  },
   	  ……
  ]
}
```

##### 2. 搜索学生成绩

```
http://api/searchaworkGrade?keywords
```

参数：

| 参数名   | 类型   | 是否可空 | 说明   |
| -------- | ------ | -------- | ------ |
| keywords | string | 是       | 关键词 |

返回：

| 字段        | 类型   | 说明     |
| ----------- | ------ | -------- |
| retcode     | int    | 返回值   |
| studentList | array  | 学生数组 |
| studnetId   | int    | 学生id   |
| studentname | string | 姓名     |

```json
{
  "retcode":0,
  "studentList":[
   	  {
   		"studnetId":1,
   		"studentname":"张三"
   	  },
      {
   		"studnetId":2,
   		"studentname":"李四"
   	  },
   	  ……
  ]
}
```

#### 8.实验成绩

#### 9.考试成绩

#### 10.成绩汇总

```
http://api/gradeList?courseId=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明             |
| -------- | ---- | -------- | ---------------- |
| courseId | int  | 否       | 课程id           |
| count    | int  | 是       | 每页记录数量     |
| page     | int  | 是       | 第几页， 从1开始 |

返回：

| 字段        | 类型          | 说明           |
| ----------- | ------------- | -------------- |
| retcode     | int           | 返回码         |
| pagecount   | int           | 数据总共有几页 |
| recordcount | int           | 总共记录数     |
| isfirst     | bool          | 是否是第一页   |
| hasnext     | bool          | 是否还有下一页 |
| studentInfo | array[object] |                |
| studentId   | int           | 学生id         |
| studentName | string        | 学生姓名       |

```json
{
   "retcode":0,
    "pagecount" : 1, 
    "recordcount" : 1, 
    "isfirst" : false, 
    "hasnext" : true, 
    "studentInfo":[
    	{
    	  "studentId":1,
    	  "studentName":"张三",
    	},
    	{
    	  "studentId":2,
    	  "studentName":"李四",
    	},
    	……
    ]
}
```

##### 1. 获取单个学生汇总成绩

```
http://api/grade?studnetId=1&courseId=1
```

参数：

| 参数名    | 类型 | 是否可空 | 说明   |
| --------- | ---- | -------- | ------ |
| studnetId | int  | 否       | 学生id |
| courseId  | int  | 否       | 课程id |

返回：

| 字段       | 类型   | 说明                 |
| ---------- | ------ | -------------------- |
| retcode    | int    | 返回值               |
| name       | string | 学生姓名             |
| class      | string | 班级                 |
| gender     | int    | 性别（默认0男，女1） |
| workgrade  | float  | 作业成绩             |
| labgrade   | float  | 实验成绩             |
| testgrade1 | float  | 考试成绩1            |
| testgrade2 | float  | 考试成绩2            |
| testgrade3 | float  | 考试成绩3            |
| testgrade4 | float  | 考试成绩4            |
| testgrade5 | float  | 考试成绩5            |
| finalgrade | float  | 最终成绩             |
| level      | string | 等级                 |

```json
{
    "retcode":0,
    "name":"姓名",
    "class":"班级",
    "gender":"性别",
    "workgrade":"作业成绩",
    "labgrade":"实验成绩",
    "testgrade1" :"100",
    "testgrade2" :"100",
    "testgrade3" :"100",
    "testgrade4" :"100",
    "testgrade5" :"100",
    "finalgrade" :"100",
    "level" :"等级"
}
```

#### 11.试卷打印

```
http://api/printTest?courseId=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明   |
| -------- | ---- | -------- | ------ |
| courseId | int  | 否       | 课程id |

返回：

| 字段        | 类型          | 说明           |
| ----------- | ------------- | -------------- |
| retcode     | int           | 返回码         |
| pagecount   | int           | 数据总共有几页 |
| recordcount | int           | 总共记录数     |
| isfirst     | bool          | 是否是第一页   |
| hasnext     | bool          | 是否还有下一页 |
| printInfo   | array[object] |                |
| id          | int           | 打印试卷id     |
| name        | string        | 打印试卷名称   |

```json
{
   "retcode":0,
    "pagecount" : 1, 
    "recordcount" : 1, 
    "isfirst" : false, 
    "hasnext" : true, 
    "printInfo":[
    	{
    	  "id":1,
    	  "name":"试卷1",
    	},
    	{
    	  "id":2,
    	  "name":"试卷2",
    	},
    	……
    ]
}
```

#####  1.获取打印考试详细信息

```
http://api/getPrintInfo?courseId=1&id=1
```

参数：

| 参数名   | 类型 | 是否可空 | 说明       |
| -------- | ---- | -------- | ---------- |
| courseId | int  | 否       | 课程id     |
| id       | int  | 否       | 打印试卷id |

返回：

| 字段      | 类型          | 说明     |
| --------- | ------------- | -------- |
| retcode   | int           | 返回码   |
|           | array[object] |          |
| count     | int           | 数量     |
| startTime | string        | 开始时间 |
| endTime   | string        | 结束时间 |
| status    | string        | 状态     |
| result    | string        | 结果     |

```json
{
  "retcode":0,
  "printInfo":[
    {
      "count":1,
      "startTime":"开始时间",
      "endTime":"结束时间",
      "status":"状态",
      "result":"结果"
    }
  ]
}
```

##### 2. 新建打印

```
http://api/createdPrint?courseId=1
```

参数：

| 参数名    | 类型          | 是否可空 | 说明   |
| --------- | ------------- | -------- | ------ |
| courseId  | int           | 否       | 课程id |
| printInfo | array[object] |          |        |

返回：

| 字段    | 类型 | 说明   |
| ------- | ---- | ------ |
| retcode | int  | 返回码 |

##### 3. 重启打印

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

##### 4. 删除打印

```
http://api/deletePrint?id=1
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





