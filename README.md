# WCF-Usage

WCF 如何使用的例子

### WCF-Demo

该项目演示了Windows应用的三层架构：客户端，WCF服务器端（中间件），服务器端。

其中` WinformsFormApplication1`是客户端。`cmdService`是中间服务程序。两者通过WCF的`TCP`方式进行通信。客户端调用服务器端的方法让服务器去操作SQLServer数据库。


### CaculatorService

此例演示了如何创建一个简单的WCF `TCP`服务。