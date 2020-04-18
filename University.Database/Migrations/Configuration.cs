namespace University.Database.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using University.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<University.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(University.Database.MyDatabase context)
        {
            #region Seed Univerisity System

            #region Seed Trainer
            //=================Seeding Trainers=================
            Trainer t1 = new Trainer() { FirstName = "Hector", LastName = "Gatsos", Subject = "C#", PhotoUrl = "http://www.spoudasefest.gr/sites/default/files/styles/square/public/fotografia_gkatsos_1.jpg?itok=b24D-IUm" };
            Trainer t2 = new Trainer() { FirstName = "George", LastName = "Pasparakis", Subject = "Java", PhotoUrl = "https://media-exp1.licdn.com/dms/image/C4E03AQFWuZhYfo-rbg/profile-displayphoto-shrink_200_200/0?e=1586995200&v=beta&t=TCz1Q7XZmTArKTRnGIJGlsVJGR1_Hv6aYFq2kA2NrTE" };
            Trainer t3 = new Trainer() { FirstName = "Kostas", LastName = "Minaidis", Subject = "Javascript", PhotoUrl = "https://beyond91.cafebabel.com/wp-content/uploads/2016/12/@PhotoMedium-bw.jpg" };
            Trainer t4 = new Trainer() { FirstName = "Kostas", LastName = "Stroggylos", Subject = "Databases", PhotoUrl = "https://media-exp1.licdn.com/dms/image/C5103AQFMQARMZAJc-Q/profile-displayphoto-shrink_200_200/0?e=1586995200&v=beta&t=dLec_08Rf4TjOmBL2vlXne_9XAnMaKoxCmA35DTammA" };
            Trainer t5 = new Trainer() { FirstName = "Panagiotis", LastName = "Bozas", Subject = "C#", PhotoUrl = "https://media-exp1.licdn.com/dms/image/C5103AQHapdeJGARTlw/profile-displayphoto-shrink_200_200/0?e=1586995200&v=beta&t=c4441f72qyg31oDrrvaJm7DkVSvbClwJ3KJQor3PeQk" };
            Trainer t6 = new Trainer() { FirstName = "Vasilis", LastName = "Tzelepopoulos", Subject = "Html-Css", PhotoUrl = "https://pbs.twimg.com/profile_images/955488926365569024/GnDMMyGf.jpg" };
            //Trainer t = new Trainer() { FirstName = "", LastName = "", Subject = "" };
            #endregion

            #region Seed Student
            //=================Seeding Students=================
            Student s1 = new Student() { FirstName = "Xenofon", LastName = "Vlachogiannis", DateOfBirth = new DateTime(1989, 8, 1), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/54428305_798369990539121_110863100298657792_n.jpg?_nc_cat=102&_nc_sid=dbb9e7&_nc_ohc=FLuw-nBKRPwAX_TOHGD&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=b392127f7f1de4e37166db034ce5e609&oe=5EAE79CE" };
            Student s2 = new Student() { FirstName = "Panagiotis", LastName = "Rizos", DateOfBirth = new DateTime(1994, 3, 19), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t31.0-1/c115.0.893.893a/s160x160/16826073_1887513254864184_8287403750433117992_o.jpg?_nc_cat=100&_nc_sid=dbb9e7&_nc_ohc=y8Y-kMo4ebIAX8BNOIF&_nc_ht=scontent.fath6-1.fna&oh=9ef084941114b180b1af03b72e2b3218&oe=5EAC5F8E" };
            Student s3 = new Student() { FirstName = "Alex", LastName = "Perikleous", DateOfBirth = new DateTime(1994, 5, 10), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/82950204_2774403002654007_5346124270697185280_o.jpg?_nc_cat=111&_nc_sid=dbb9e7&_nc_ohc=JmwzATYcOI8AX9dSRSQ&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=28cfba789e630071efa6607e74f02b21&oe=5EABD3B1" };
            Student s4 = new Student() { FirstName = "Evangelos", LastName = "Koutsogiorgos", DateOfBirth = new DateTime(1987, 2, 27), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/39227285_10212385055998460_863179656449228800_o.jpg?_nc_cat=104&_nc_sid=dbb9e7&_nc_ohc=x-EvdkI1MK4AX_gTAhL&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=062af127cca95bb86ed3d69ff0daedaa&oe=5EACE470" };
            Student s5 = new Student() { FirstName = "Zacharias", LastName = "Drimiskianakis", DateOfBirth = new DateTime(1993, 2, 21), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t31.0-1/p160x160/27747689_1760922243939546_4872129996443956546_o.jpg?_nc_cat=105&_nc_sid=dbb9e7&_nc_ohc=PvxCieEs-ZgAX-FqiXU&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=42b86e4416251041cb4f8fb811d99f97&oe=5EAE51F7" };
            Student s6 = new Student() { FirstName = "Eleni", LastName = "Parisi", DateOfBirth = new DateTime(1989, 11, 16), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/44643459_1990574251006318_6459707710278467584_o.jpg?_nc_cat=105&_nc_sid=dbb9e7&_nc_ohc=6nHMZjZ6iKwAX_2HsVt&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=81accc94d712c716ef9cdd7c5f2cbe3f&oe=5EADA16D" };
            Student s7 = new Student() { FirstName = "Thanos", LastName = "Katrakis", DateOfBirth = new DateTime(1990, 12, 07), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/c227.342.944.944a/s160x160/89728089_216226096428302_4082566749302554624_o.jpg?_nc_cat=110&_nc_sid=dbb9e7&_nc_ohc=5ssUMXflsf4AX98prSH&_nc_ht=scontent.fath6-1.fna&oh=12154e5d6418bc1b889f8a82f02c2c83&oe=5EAC38D9" };
            Student s8 = new Student() { FirstName = "Albi", LastName = "Alikaj", DateOfBirth = new DateTime(1991, 6, 26), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/c0.5.160.160a/p160x160/84947519_10221639470159874_2595289818887880704_o.jpg?_nc_cat=108&_nc_sid=dbb9e7&_nc_ohc=T3CFXbOgRdIAX9E18Fo&_nc_ht=scontent.fath6-1.fna&oh=591c46f368b3aa030279a809dab619df&oe=5EAEA85C" };
            Student s9 = new Student() { FirstName = "Karol", LastName = "Koniewicz", DateOfBirth = new DateTime(1994, 11, 4), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/c0.0.160.160a/p160x160/60247548_1531966373605919_5288819833486442496_o.jpg?_nc_cat=106&_nc_sid=dbb9e7&_nc_ohc=noA78_rrYRYAX9N9Jhn&_nc_ht=scontent.fath6-1.fna&oh=fc604671046b9139b027fa2c29932a44&oe=5EAAFFA3" };
            Student s10 = new Student() { FirstName = "Thanos", LastName = "Christidis", DateOfBirth = new DateTime(1992, 5, 07), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/c0.0.160.160a/p160x160/67228954_10217557567524921_7110492575286427648_o.jpg?_nc_cat=104&_nc_sid=dbb9e7&_nc_ohc=KuFqVmyonwUAX8Odna_&_nc_ht=scontent.fath6-1.fna&oh=cd553fca9b8e35538ff945d7f5ef4894&oe=5EACFD2F" };
            Student s11 = new Student() { FirstName = "Ioannis", LastName = "Elefsiniotis", DateOfBirth = new DateTime(1975, 4, 29), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/61049396_837895846579582_4168353704518352896_o.jpg?_nc_cat=110&_nc_sid=dbb9e7&_nc_ohc=Z7pzzKkslNMAX9QPBVQ&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=ceb8445e5d281fb882da087bf3ed1f2d&oe=5EAB5D6D" };
            Student s12 = new Student() { FirstName = "Konstantinos", LastName = "Argyropoulos", DateOfBirth = new DateTime(1996, 12, 3), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/45150388_489501521548146_1303393901410779136_n.jpg?_nc_cat=109&_nc_sid=dbb9e7&_nc_ohc=XqWvxMbtcq8AX-hWfK6&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=1a84994849e71701c0629b65d42ea369&oe=5EACCBF1" };
            Student s13 = new Student() { FirstName = "Chris", LastName = "Vasilakis", DateOfBirth = new DateTime(1989, 7, 3), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/39755150_2135619819844294_8578400753679335424_n.jpg?_nc_cat=101&_nc_sid=dbb9e7&_nc_ohc=-41rLiHwXpQAX8YJ4V8&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=d7c7d9f33bda42b4bfe673d3b3d55dc1&oe=5EADB5AB" };
            Student s14 = new Student() { FirstName = "Eustathios", LastName = "Kanellis", DateOfBirth = new DateTime(1986, 10, 30), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t31.0-1/c94.94.1177.1177a/s160x160/285972_2085671995911_1552357_o.jpg?_nc_cat=107&_nc_sid=dbb9e7&_nc_ohc=BD7IR4mvbFUAX8cKOZT&_nc_ht=scontent.fath6-1.fna&oh=648c2b6b2deff19d37ec2e63f0ee0bff&oe=5EAB4618" };
            Student s15 = new Student() { FirstName = "Dionysios", LastName = "Pilikas", DateOfBirth = new DateTime(1983, 4, 21), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/91377105_1493976710773823_144926052131536896_o.jpg?_nc_cat=111&_nc_sid=dbb9e7&_nc_ohc=k9il_zpf3HUAX9u05HJ&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=2bc0534d41d0d4e2e42221027003e9f7&oe=5EACE6A3" };
            Student s16 = new Student() { FirstName = "Athanasios", LastName = "Kontodimas", DateOfBirth = new DateTime(1989, 9, 20), PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/1200px-No_image_available.svg.png" };
            Student s17 = new Student() { FirstName = "Ioannis", LastName = "Manthos", DateOfBirth = new DateTime(1969, 3, 3), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/88302137_101199051509909_4621936851232489472_n.jpg?_nc_cat=100&_nc_sid=dbb9e7&_nc_ohc=LRDfNd1eyt8AX_pKyi7&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=57af7a6cd7332e2ac95bfd254f99afc9&oe=5EAEAFEC" };
            Student s18 = new Student() { FirstName = "Themistoklis", LastName = "Papageorgiou", DateOfBirth = new DateTime(1995, 8, 14), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/c0.27.160.160a/p160x160/84863141_193902371850182_1184395123736182784_o.jpg?_nc_cat=102&_nc_sid=dbb9e7&_nc_ohc=T0GYWvoNXaAAX_M0ROL&_nc_ht=scontent.fath6-1.fna&oh=fd99d4e5121abe7edc4700cb59b72765&oe=5EAC0680" };
            Student s19 = new Student() { FirstName = "Giorgos", LastName = "Poulakos", DateOfBirth = new DateTime(1987, 10, 17), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/r180/p160x160/52602285_10216530072378614_3337311046372163584_o.jpg?_nc_cat=111&_nc_sid=dbb9e7&_nc_ohc=e1fBsjjDQ_0AX8ZXSfY&_nc_ht=scontent.fath6-1.fna&oh=a0b5f7c1fd3b2ff2e04f30e938391088&oe=5EAEAD42" };
            Student s20 = new Student() { FirstName = "Kyriakos", LastName = "Zotiadis", DateOfBirth = new DateTime(1996, 2, 25), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/84630614_1474513026042402_2895005899661770752_o.jpg?_nc_cat=107&_nc_sid=dbb9e7&_nc_ohc=eYDyIWM5a48AX-nqE8M&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=b78ee0e63897fed9c5944852aab0bc1e&oe=5EAD0B94" };
            Student s21 = new Student() { FirstName = "Vasileios", LastName = "Theodoropoulos", DateOfBirth = new DateTime(1991, 5, 26), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/72421681_10219149774165939_7754066757140086784_o.jpg?_nc_cat=100&_nc_sid=dbb9e7&_nc_ohc=PeTP1MvgW3EAX-GfGiz&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=96e0fd50213cc94f0e822b65bb228ea3&oe=5EAB2837" };
            Student s22 = new Student() { FirstName = "Dimitrios", LastName = "Gkotsis", DateOfBirth = new DateTime(1989, 11, 29), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t31.0-1/p160x160/22467607_1805134289516261_6199419177410518079_o.jpg?_nc_cat=109&_nc_sid=dbb9e7&_nc_ohc=ITaph7xmJu4AX_YDEDf&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=e461ab13cb132330feb12a8a24999008&oe=5EAC1070" };
            Student s23 = new Student() { FirstName = "Thodoris", LastName = "Thanos", DateOfBirth = new DateTime(1989, 4, 3), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/88197206_10221884389688282_2969913041291837440_o.jpg?_nc_cat=111&_nc_sid=dbb9e7&_nc_ohc=IWjPdkq2rhgAX9Wm74b&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=935c1437b2a84f8b28978fbfcb4a9d2e&oe=5EACDF11" };
            Student s24 = new Student() { FirstName = "Vasilios", LastName = "Mourtzinos", DateOfBirth = new DateTime(1989, 8, 10), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/69854692_10220392423504749_6036645172400357376_n.jpg?_nc_cat=102&_nc_sid=dbb9e7&_nc_ohc=Y8AoMG3OXhkAX94IMHg&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=eead0c1a74d4e78e4f2bc8023e470b2c&oe=5EAC3D3E" };
            Student s25 = new Student() { FirstName = "Katerina", LastName = "Mos", DateOfBirth = new DateTime(1993, 10, 13), PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/1200px-No_image_available.svg.png" };
            Student s26 = new Student() { FirstName = "Peny", LastName = "Panagopoulou", DateOfBirth = new DateTime(1990, 3, 1), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/37706199_10217035227698667_4979261568865796096_o.jpg?_nc_cat=108&_nc_sid=dbb9e7&_nc_ohc=Fn6cR2W41jcAX_4oRCX&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=34c5fa54fe4460607b8ae9f83dd51d5f&oe=5EAD9B20" };
            Student s27 = new Student() { FirstName = "Alex", LastName = "Stergiou", DateOfBirth = new DateTime(1991, 5, 1), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/c0.0.160.160a/p160x160/74569605_10218462029234313_7300403818523525120_o.jpg?_nc_cat=108&_nc_sid=dbb9e7&_nc_ohc=aCIQL4tKLZEAX_HwTjH&_nc_ht=scontent.fath6-1.fna&oh=22bc66a769a74eb15950f82ca00cd905&oe=5EAD34A9" };
            Student s28 = new Student() { FirstName = "Dionisis", LastName = "Gialpas", DateOfBirth = new DateTime(1990, 10, 11), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/38072234_10217079765373334_4457410947773890560_n.jpg?_nc_cat=105&_nc_sid=dbb9e7&_nc_ohc=ldHWmdC2AqEAX8tjyr1&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=5dc717f03125f8a32b1815018ce31622&oe=5EAE706C" };
            Student s29 = new Student() { FirstName = "Spyros", LastName = "Ntatsikas", DateOfBirth = new DateTime(1988, 3, 8), PhotoUrl = "https://scontent.fath6-1.fna.fbcdn.net/v/t1.0-1/p160x160/31689245_10204206595602579_214031208340783104_n.jpg?_nc_cat=102&_nc_sid=dbb9e7&_nc_ohc=jfvcaxkq-YkAX_bXzF4&_nc_ht=scontent.fath6-1.fna&_nc_tp=6&oh=6c881cf3314ac8ef3250a609940837ff&oe=5EAE26DD" };
            Student s30 = new Student() { FirstName = "Irene", LastName = "Zarologlou", DateOfBirth = new DateTime(1998, 5, 4), PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/1200px-No_image_available.svg.png" };
            //Student s = new Student() { FirstName = "", LastName = "", DateOfBirth = new DateTime(1111, 1, 19) };
            #endregion

            #region Seed Assignment
            //=================Seeding Assignments=================
            Assignment a1 = new Assignment() { Title = "Private School A", Description = "Create a private school with c#", SubDate = new DateTime(2019, 12, 21), PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTd00TyEufzro7-y9xbDh5dDbVrKa6Qkv6mkugxwlIlGGSbdOH3&s" };
            Assignment a2 = new Assignment() { Title = "Private School B", Description = "Create a private school with ADO", SubDate = new DateTime(2020, 1, 16), PhotoUrl = "https://static.javatpoint.com/ado/images/ado-net-tutorial.jpg" };
            Assignment a3 = new Assignment() { Title = "Private School C", Description = "Create a private school with Entity", SubDate = new DateTime(2020, 1, 29), PhotoUrl = "https://3.bp.blogspot.com/-IHOi-jypA-Q/XQYQrhidHqI/AAAAAAAAD9U/O9bLB6b9GRow6_WE72dL4qwoSG8-ba3lgCLcBGAs/s1600/entity-framework.png" };
            Assignment a4 = new Assignment() { Title = "School Java A", Description = "Create a Java program", SubDate = new DateTime(2019, 12, 19), PhotoUrl = "https://www.swiss4ward.com/.imaging/mte/swiss4ward-theme/thumbnail-list/dam/technologies-LOGOS/Java_Logo_Swiss4ward.jpg/jcr:content/Java_Logo_Swiss4ward.jpg.jpg" };
            Assignment a5 = new Assignment() { Title = "School Java B", Description = "Create a Java program with database", SubDate = new DateTime(2020, 1, 11), PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTn7VWxSEUyeyyMU9gQrX7wm22mhIeub1pLhFbIBvI6bI8OkDD8Ig&s" };
            Assignment a6 = new Assignment() { Title = "School Java C", Description = "Create a Java program with mvc", SubDate = new DateTime(2020, 2, 08), PhotoUrl = "https://www.pngkey.com/png/detail/264-2646582_logo-transparent-background-java.png" };
            Assignment a7 = new Assignment() { Title = "Bank Project Database", Description = "Create a bank system", SubDate = new DateTime(2020, 2, 10), PhotoUrl = "https://www.pngkit.com/png/detail/438-4384804_only-a-global-structured-copyright-cases-database-with.png" };
            Assignment a8 = new Assignment() { Title = "Bank Project RDBMS", Description = "Create a bank rdbms system", SubDate = new DateTime(2020, 3, 29), PhotoUrl = "https://static1.squarespace.com/static/5ccb715016b640627a1c2782/t/5cd076e84e17b66767359b5b/1557165804160/db3.jpg?format=1500w" };
            Assignment a9 = new Assignment() { Title = "Bank Project MongoDB", Description = "Create a bank mongoDb system", SubDate = new DateTime(2020, 5, 17), PhotoUrl = "https://seeklogo.net/wp-content/uploads/2015/10/mongodb-logo-vector-download.jpg" };
            Assignment a10 = new Assignment() { Title = "Website Html", Description = "Create a Website Html", SubDate = new DateTime(2020, 3, 13), PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS_fImaOCq91jNiq7mYipP_tlZx9wCyPC3edGrtrACXCWCf5ZTM&usqp=CAU" };
            Assignment a11 = new Assignment() { Title = "Website Html-Css", Description = "Create a Website with Html-CSS", SubDate = new DateTime(2020, 4, 22), PhotoUrl = "https://4.bp.blogspot.com/-uyl5kqXIMog/VSZ80P5sALI/AAAAAAAAXuI/0xCQDcWZ4jI/s1600/HTML5CSS3Logos_s.png" };
            Assignment a12 = new Assignment() { Title = "Website Javascript", Description = "Create a Website with Javasctipt", SubDate = new DateTime(2020, 7, 25), PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSjijyWPquveNFUo30p6JSrTEWcxH4aykPmzkbQnrSzzjxuBISH&usqp=CAU" };
            Assignment a13 = new Assignment() { Title = "MVC Part A", Description = "Create an MVC Angular 2", SubDate = new DateTime(2020, 3, 20), PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSgvv8EnePcYY755Yd3ReP_WXViTx5vX2zThwc9GlZ01ofYdBE-&usqp=CAU" };
            Assignment a14 = new Assignment() { Title = "MVC Part B", Description = "Create an MVC React", SubDate = new DateTime(2020, 3, 15), PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTpep6OyPg2v-OBDQQ_hA5izTrKkiGEHLyh7gVpluI1MbBk197X&usqp=CAU" };
            Assignment a15 = new Assignment() { Title = "MVC Part C", Description = "Create an MVC Angular", SubDate = new DateTime(2020, 4, 17), PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSHfPyAuZB0ap92lkxeXN7kAp-Ly6GYob4s1pdWtHRMpQklyQ5V&usqp=CAU" };
            //Assignment a = new Assignment() { Title = "", Description = "", SubDate = new DateTime(1111, 1, 19) };
            #endregion

            #region Seed Course
            //=================Seeding Courses=================
            Course c1 = new Course() { Title = "CB9-C#", Stream = "C#", CourseType = CourseType.FullTime, StartDate = new DateTime(2019, 11, 15), EndDate = new DateTime(2020, 2, 1), Fees = 2300, PhotoUrl = "https://pla.s6img.com/society6/img/nV1AknlqVm6ykWmiFTdjq2z-dIs/w_1500/prints/~artwork/s6-original-art-uploads/society6/uploads/misc/6668936326d74c3a8bf31df3bc0430eb/~~/c-logo-for-csharp-developers-visual-studio-prints.jpg" };
            Course c2 = new Course() { Title = "CB9-Java", Stream = "Java", CourseType = CourseType.FullTime, StartDate = new DateTime(2019, 11, 08), EndDate = new DateTime(2020, 2, 10), Fees = 2200, PhotoUrl = "https://pbs.twimg.com/profile_images/954020529391902720/jW4dnFtA.jpg" };
            Course c3 = new Course() { Title = "CB9-RDMBS", Stream = "RDBMS", CourseType = CourseType.PartTime, StartDate = new DateTime(2019, 11, 03), EndDate = new DateTime(2020, 6, 1), Fees = 2500, PhotoUrl = "https://www.computerhope.com/jargon/d/database.jpg" };
            Course c4 = new Course() { Title = "CB10-Javascript", Stream = "Javascript", CourseType = CourseType.PartTime, StartDate = new DateTime(2020, 2, 21), EndDate = new DateTime(2020, 8, 10), Fees = 2500, PhotoUrl = "https://4.bp.blogspot.com/-1GOghsk3j-k/XF_8G1N735I/AAAAAAAAcsU/vT7r4s-EL3gEDlzsbD4u8yu5VZo8YSuOQCLcBGAs/s1600/js.jpg" };
            Course c5 = new Course() { Title = "CB10-Angular", Stream = "Angular", CourseType = CourseType.PartTime, StartDate = new DateTime(2020, 2, 28), EndDate = new DateTime(2020, 5, 17), Fees = 2000, PhotoUrl = "https://www.zuehlke.com/blog/app/uploads/2013/04/angularjs.jpg" };
            //Course c = new Course() { Title = "", Stream = "", CourseType = CourseType.PartTime, StartDate = new DateTime(1111, 1, 19), EndDate = new DateTime(1111, 1, 19), Fees = 0 };
                #endregion

                #region Seed Marks
                //=================Seeding Marks=================
                StudentAssignmentMark m1 = new StudentAssignmentMark() { OralMark = 50, TotalMark = 61 };
            StudentAssignmentMark m2 = new StudentAssignmentMark() { OralMark = 50.5, TotalMark = 68 };
            StudentAssignmentMark m3 = new StudentAssignmentMark() { OralMark = 51, TotalMark = 68 };
            StudentAssignmentMark m4 = new StudentAssignmentMark() { OralMark = 51.5, TotalMark = 36 };
            StudentAssignmentMark m5 = new StudentAssignmentMark() { OralMark = 52, TotalMark = 68 };
            StudentAssignmentMark m6 = new StudentAssignmentMark() { OralMark = 52.5, TotalMark = 56 };
            StudentAssignmentMark m7 = new StudentAssignmentMark() { OralMark = 53, TotalMark = 16 };
            StudentAssignmentMark m8 = new StudentAssignmentMark() { OralMark = 53.5, TotalMark = 93 };
            StudentAssignmentMark m9 = new StudentAssignmentMark() { OralMark = 54, TotalMark = 50 };
            StudentAssignmentMark m10 = new StudentAssignmentMark() { OralMark = 54.5, TotalMark = 43 };
            StudentAssignmentMark m11 = new StudentAssignmentMark() { OralMark = 55, TotalMark = 98 };
            StudentAssignmentMark m12 = new StudentAssignmentMark() { OralMark = 55.5, TotalMark = 54 };
            StudentAssignmentMark m13 = new StudentAssignmentMark() { OralMark = 56, TotalMark = 32 };
            StudentAssignmentMark m14 = new StudentAssignmentMark() { OralMark = 56.5, TotalMark = 61 };
            StudentAssignmentMark m15 = new StudentAssignmentMark() { OralMark = 57, TotalMark = 36 };
            StudentAssignmentMark m16 = new StudentAssignmentMark() { OralMark = 57.5, TotalMark = 36 };
            StudentAssignmentMark m17 = new StudentAssignmentMark() { OralMark = 58, TotalMark = 66 };
            StudentAssignmentMark m18 = new StudentAssignmentMark() { OralMark = 58.5, TotalMark = 41 };
            StudentAssignmentMark m19 = new StudentAssignmentMark() { OralMark = 59, TotalMark = 15 };
            StudentAssignmentMark m20 = new StudentAssignmentMark() { OralMark = 59.5, TotalMark = 65 };
            StudentAssignmentMark m21 = new StudentAssignmentMark() { OralMark = 60, TotalMark = 50 };
            StudentAssignmentMark m22 = new StudentAssignmentMark() { OralMark = 60.5, TotalMark = 19 };
            StudentAssignmentMark m23 = new StudentAssignmentMark() { OralMark = 61, TotalMark = 43 };
            StudentAssignmentMark m24 = new StudentAssignmentMark() { OralMark = 61.5, TotalMark = 71 };
            StudentAssignmentMark m25 = new StudentAssignmentMark() { OralMark = 62, TotalMark = 14 };
            StudentAssignmentMark m26 = new StudentAssignmentMark() { OralMark = 62.5, TotalMark = 99 };
            StudentAssignmentMark m27 = new StudentAssignmentMark() { OralMark = 63, TotalMark = 20 };
            StudentAssignmentMark m28 = new StudentAssignmentMark() { OralMark = 63.5, TotalMark = 66 };
            StudentAssignmentMark m29 = new StudentAssignmentMark() { OralMark = 64, TotalMark = 57 };
            StudentAssignmentMark m30 = new StudentAssignmentMark() { OralMark = 64.5, TotalMark = 46 };
            StudentAssignmentMark m31 = new StudentAssignmentMark() { OralMark = 65, TotalMark = 56 };
            StudentAssignmentMark m32 = new StudentAssignmentMark() { OralMark = 65.5, TotalMark = 97 };
            StudentAssignmentMark m33 = new StudentAssignmentMark() { OralMark = 66, TotalMark = 66 };
            StudentAssignmentMark m34 = new StudentAssignmentMark() { OralMark = 66.5, TotalMark = 66 };
            StudentAssignmentMark m35 = new StudentAssignmentMark() { OralMark = 67, TotalMark = 32 };
            StudentAssignmentMark m36 = new StudentAssignmentMark() { OralMark = 67.5, TotalMark = 38 };
            StudentAssignmentMark m37 = new StudentAssignmentMark() { OralMark = 68, TotalMark = 56 };
            StudentAssignmentMark m38 = new StudentAssignmentMark() { OralMark = 68.5, TotalMark = 81 };
            StudentAssignmentMark m39 = new StudentAssignmentMark() { OralMark = 69, TotalMark = 7 };
            StudentAssignmentMark m40 = new StudentAssignmentMark() { OralMark = 69.5, TotalMark = 2 };
            StudentAssignmentMark m41 = new StudentAssignmentMark() { OralMark = 70, TotalMark = 25 };
            StudentAssignmentMark m42 = new StudentAssignmentMark() { OralMark = 70.5, TotalMark = 34 };
            StudentAssignmentMark m43 = new StudentAssignmentMark() { OralMark = 71, TotalMark = 61 };
            StudentAssignmentMark m44 = new StudentAssignmentMark() { OralMark = 71.5, TotalMark = 23 };
            StudentAssignmentMark m45 = new StudentAssignmentMark() { OralMark = 72, TotalMark = 96 };
            StudentAssignmentMark m46 = new StudentAssignmentMark() { OralMark = 72.5, TotalMark = 38 };
            StudentAssignmentMark m47 = new StudentAssignmentMark() { OralMark = 73, TotalMark = 4 };
            StudentAssignmentMark m48 = new StudentAssignmentMark() { OralMark = 73.5, TotalMark = 44 };
            StudentAssignmentMark m49 = new StudentAssignmentMark() { OralMark = 74, TotalMark = 59 };
            StudentAssignmentMark m50 = new StudentAssignmentMark() { OralMark = 74.5, TotalMark = 83 };
            StudentAssignmentMark m51 = new StudentAssignmentMark() { OralMark = 75, TotalMark = 63 };
            StudentAssignmentMark m52 = new StudentAssignmentMark() { OralMark = 75.5, TotalMark = 24 };
            StudentAssignmentMark m53 = new StudentAssignmentMark() { OralMark = 76, TotalMark = 77 };
            StudentAssignmentMark m54 = new StudentAssignmentMark() { OralMark = 76.5, TotalMark = 18 };
            StudentAssignmentMark m55 = new StudentAssignmentMark() { OralMark = 77, TotalMark = 25 };
            StudentAssignmentMark m56 = new StudentAssignmentMark() { OralMark = 77.5, TotalMark = 40 };
            StudentAssignmentMark m57 = new StudentAssignmentMark() { OralMark = 78, TotalMark = 72 };
            StudentAssignmentMark m58 = new StudentAssignmentMark() { OralMark = 78.5, TotalMark = 93 };
            StudentAssignmentMark m59 = new StudentAssignmentMark() { OralMark = 79, TotalMark = 47 };
            StudentAssignmentMark m60 = new StudentAssignmentMark() { OralMark = 79.5, TotalMark = 26 };
            StudentAssignmentMark m61 = new StudentAssignmentMark() { OralMark = 80, TotalMark = 86 };
            StudentAssignmentMark m62 = new StudentAssignmentMark() { OralMark = 80.5, TotalMark = 59 };
            StudentAssignmentMark m63 = new StudentAssignmentMark() { OralMark = 81, TotalMark = 88 };
            StudentAssignmentMark m64 = new StudentAssignmentMark() { OralMark = 81.5, TotalMark = 26 };
            StudentAssignmentMark m65 = new StudentAssignmentMark() { OralMark = 82, TotalMark = 75 };
            StudentAssignmentMark m66 = new StudentAssignmentMark() { OralMark = 82.5, TotalMark = 12 };
            StudentAssignmentMark m67 = new StudentAssignmentMark() { OralMark = 83, TotalMark = 74 };
            StudentAssignmentMark m68 = new StudentAssignmentMark() { OralMark = 83.5, TotalMark = 86 };
            StudentAssignmentMark m69 = new StudentAssignmentMark() { OralMark = 84, TotalMark = 51 };
            StudentAssignmentMark m70 = new StudentAssignmentMark() { OralMark = 84.5, TotalMark = 59 };
            StudentAssignmentMark m71 = new StudentAssignmentMark() { OralMark = 85, TotalMark = 10 };
            StudentAssignmentMark m72 = new StudentAssignmentMark() { OralMark = 85.5, TotalMark = 98 };
            StudentAssignmentMark m73 = new StudentAssignmentMark() { OralMark = 86, TotalMark = 45 };
            StudentAssignmentMark m74 = new StudentAssignmentMark() { OralMark = 86.5, TotalMark = 9 };
            StudentAssignmentMark m75 = new StudentAssignmentMark() { OralMark = 87, TotalMark = 62 };
            StudentAssignmentMark m76 = new StudentAssignmentMark() { OralMark = 87.5, TotalMark = 87 };
            StudentAssignmentMark m77 = new StudentAssignmentMark() { OralMark = 88, TotalMark = 9 };
            StudentAssignmentMark m78 = new StudentAssignmentMark() { OralMark = 88.5, TotalMark = 12 };
            StudentAssignmentMark m79 = new StudentAssignmentMark() { OralMark = 89, TotalMark = 78 };
            StudentAssignmentMark m80 = new StudentAssignmentMark() { OralMark = 89.5, TotalMark = 66 };
            StudentAssignmentMark m81 = new StudentAssignmentMark() { OralMark = 90, TotalMark = 80 };
            StudentAssignmentMark m82 = new StudentAssignmentMark() { OralMark = 90.5, TotalMark = 85 };
            StudentAssignmentMark m83 = new StudentAssignmentMark() { OralMark = 91, TotalMark = 99 };
            StudentAssignmentMark m84 = new StudentAssignmentMark() { OralMark = 91.5, TotalMark = 78 };
            StudentAssignmentMark m85 = new StudentAssignmentMark() { OralMark = 92, TotalMark = 22 };
            StudentAssignmentMark m86 = new StudentAssignmentMark() { OralMark = 92.5, TotalMark = 51 };
            StudentAssignmentMark m87 = new StudentAssignmentMark() { OralMark = 93, TotalMark = 4 };
            StudentAssignmentMark m88 = new StudentAssignmentMark() { OralMark = 93.5, TotalMark = 14 };
            StudentAssignmentMark m89 = new StudentAssignmentMark() { OralMark = 94, TotalMark = 17 };
            StudentAssignmentMark m90 = new StudentAssignmentMark() { OralMark = 94.5, TotalMark = 8 };
            StudentAssignmentMark m91 = new StudentAssignmentMark() { OralMark = 95, TotalMark = 35 };
            StudentAssignmentMark m92 = new StudentAssignmentMark() { OralMark = 95.5, TotalMark = 82 };
            StudentAssignmentMark m93 = new StudentAssignmentMark() { OralMark = 96, TotalMark = 5 };
            StudentAssignmentMark m94 = new StudentAssignmentMark() { OralMark = 96.5, TotalMark = 96 };
            StudentAssignmentMark m95 = new StudentAssignmentMark() { OralMark = 97, TotalMark = 56 };
            StudentAssignmentMark m96 = new StudentAssignmentMark() { OralMark = 97.5, TotalMark = 63 };
            StudentAssignmentMark m97 = new StudentAssignmentMark() { OralMark = 98, TotalMark = 26 };
            StudentAssignmentMark m98 = new StudentAssignmentMark() { OralMark = 98.5, TotalMark = 37 };
            StudentAssignmentMark m99 = new StudentAssignmentMark() { OralMark = 99, TotalMark = 33 };
            StudentAssignmentMark m100 = new StudentAssignmentMark() { OralMark = 99.5, TotalMark = 96 };
            StudentAssignmentMark m101 = new StudentAssignmentMark() { OralMark = 100, TotalMark = 61 };
            StudentAssignmentMark m102 = new StudentAssignmentMark() { OralMark = 49, TotalMark = 33 };
            //StudentAssignmentMark m = new StudentAssignmentMark() { OralMark = , TotalMark =  };
            #endregion


            #region Add Trainers, Assignments & Students to Courses
            //==========Add Trainers to Courses
            c1.Trainers = new List<Trainer>() { t1, t4, t5 };
            c2.Trainers = new List<Trainer>() { t2, t4 };
            c3.Trainers = new List<Trainer>() { t4, t5 };
            c4.Trainers = new List<Trainer>() { t3, t6 };
            c5.Trainers = new List<Trainer>() { t3, t6 };

            //==========Add Assignments to Courses
            c1.Assignments = new List<Assignment>() { a1, a2, a3 };
            c2.Assignments = new List<Assignment>() { a4, a5, a6 };
            c3.Assignments = new List<Assignment>() { a7, a8, a9 };
            c4.Assignments = new List<Assignment>() { a10, a11, a12 };
            c5.Assignments = new List<Assignment>() { a13, a14, a15 };

            //==========Add Students to Courses
            c1.Students = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            c2.Students = new List<Student>() { s7, s8, s9, s10, s11, s12, s26 };
            c3.Students = new List<Student>() { s1, s13, s14, s15, s16, s17, s18 };
            c4.Students = new List<Student>() { s2, s19, s20, s21, s22, s23, s24 };
            c5.Students = new List<Student>() { s3, s25, s26, s27, s28, s29, s30 };
            #endregion

            #region Add Marks to Student & Assignment            
            //==========Add Marks to Student & Assignment
            m1.Assignment = a1;
            m1.Student = s1;
            m2.Assignment = a2;
            m2.Student = s1;
            m3.Assignment = a3;
            m3.Student = s1;
            m4.Assignment = a1;
            m4.Student = s2;
            m5.Assignment = a2;
            m5.Student = s2;
            m6.Assignment = a3;
            m6.Student = s2;
            m7.Assignment = a1;
            m7.Student = s3;
            m8.Assignment = a2;
            m8.Student = s3;
            m9.Assignment = a3;
            m9.Student = s3;
            m10.Assignment = a1;
            m10.Student = s4;
            m11.Assignment = a2;
            m11.Student = s4;
            m12.Assignment = a3;
            m12.Student = s4;
            m13.Assignment = a1;
            m13.Student = s5;
            m14.Assignment = a2;
            m14.Student = s5;
            m15.Assignment = a3;
            m15.Student = s5;
            m16.Assignment = a1;
            m16.Student = s6;
            m17.Assignment = a2;
            m17.Student = s6;
            m18.Assignment = a3;
            m18.Student = s6;
            m19.Assignment = a4;
            m19.Student = s7;
            m20.Assignment = a5;
            m20.Student = s7;
            m21.Assignment = a6;
            m21.Student = s7;
            m22.Assignment = a4;
            m22.Student = s8;
            m23.Assignment = a5;
            m23.Student = s8;
            m24.Assignment = a6;
            m24.Student = s8;
            m25.Assignment = a4;
            m25.Student = s9;
            m26.Assignment = a5;
            m26.Student = s9;
            m27.Assignment = a6;
            m27.Student = s9;
            m28.Assignment = a4;
            m28.Student = s10;
            m29.Assignment = a5;
            m29.Student = s10;
            m30.Assignment = a6;
            m30.Student = s10;
            m31.Assignment = a4;
            m31.Student = s11;
            m32.Assignment = a5;
            m32.Student = s11;
            m33.Assignment = a6;
            m33.Student = s11;
            m34.Assignment = a4;
            m34.Student = s12;
            m35.Assignment = a5;
            m35.Student = s12;
            m36.Assignment = a6;
            m36.Student = s12;
            m37.Assignment = a7;
            m37.Student = s13;
            m38.Assignment = a8;
            m38.Student = s13;
            m39.Assignment = a9;
            m39.Student = s13;
            m40.Assignment = a7;
            m40.Student = s14;
            m41.Assignment = a8;
            m41.Student = s14;
            m42.Assignment = a9;
            m42.Student = s14;
            m43.Assignment = a7;
            m43.Student = s15;
            m44.Assignment = a8;
            m44.Student = s15;
            m45.Assignment = a9;
            m45.Student = s15;
            m46.Assignment = a7;
            m46.Student = s16;
            m47.Assignment = a8;
            m47.Student = s16;
            m48.Assignment = a9;
            m48.Student = s16;
            m49.Assignment = a7;
            m49.Student = s17;
            m50.Assignment = a8;
            m50.Student = s17;
            m51.Assignment = a9;
            m51.Student = s17;
            m52.Assignment = a7;
            m52.Student = s18;
            m53.Assignment = a8;
            m53.Student = s18;
            m54.Assignment = a9;
            m54.Student = s18;
            m55.Assignment = a10;
            m55.Student = s19;
            m56.Assignment = a11;
            m56.Student = s19;
            m57.Assignment = a12;
            m57.Student = s19;
            m58.Assignment = a10;
            m58.Student = s20;
            m59.Assignment = a11;
            m59.Student = s20;
            m60.Assignment = a12;
            m60.Student = s20;
            m61.Assignment = a10;
            m61.Student = s21;
            m62.Assignment = a11;
            m62.Student = s21;
            m63.Assignment = a12;
            m63.Student = s21;
            m64.Assignment = a10;
            m64.Student = s22;
            m65.Assignment = a11;
            m65.Student = s22;
            m66.Assignment = a12;
            m66.Student = s22;
            m67.Assignment = a10;
            m67.Student = s23;
            m68.Assignment = a11;
            m68.Student = s23;
            m69.Assignment = a12;
            m69.Student = s23;
            m70.Assignment = a10;
            m70.Student = s24;
            m71.Assignment = a11;
            m71.Student = s24;
            m72.Assignment = a12;
            m72.Student = s24;
            m73.Assignment = a13;
            m73.Student = s25;
            m74.Assignment = a14;
            m74.Student = s25;
            m75.Assignment = a15;
            m75.Student = s25;
            m76.Assignment = a13;
            m76.Student = s26;
            m77.Assignment = a14;
            m77.Student = s26;
            m78.Assignment = a15;
            m78.Student = s26;
            m79.Assignment = a13;
            m79.Student = s27;
            m80.Assignment = a14;
            m80.Student = s27;
            m81.Assignment = a15;
            m81.Student = s27;
            m82.Assignment = a13;
            m82.Student = s28;
            m83.Assignment = a14;
            m83.Student = s28;
            m84.Assignment = a15;
            m84.Student = s28;
            m85.Assignment = a13;
            m85.Student = s29;
            m86.Assignment = a14;
            m86.Student = s29;
            m87.Assignment = a15;
            m87.Student = s29;
            m88.Assignment = a13;
            m88.Student = s30;
            m89.Assignment = a14;
            m89.Student = s30;
            m90.Assignment = a15;
            m90.Student = s30;
            m91.Assignment = a7;
            m91.Student = s1;
            m92.Assignment = a8;
            m92.Student = s1;
            m93.Assignment = a9;
            m93.Student = s1;
            m94.Assignment = a10;
            m94.Student = s2;
            m95.Assignment = a11;
            m95.Student = s2;
            m96.Assignment = a12;
            m96.Student = s2;
            m97.Assignment = a13;
            m97.Student = s3;
            m98.Assignment = a14;
            m98.Student = s3;
            m99.Assignment = a15;
            m99.Student = s3;
            m100.Assignment = a4;
            m100.Student = s26;
            m101.Assignment = a5;
            m101.Student = s26;
            m102.Assignment = a6;
            m102.Student = s26;
            #endregion

            //========== Upsert Tables(Course, Trainer, Student, Assignment, StudentAssignmentMarks--Automaticly creation of University)
            context.StudentAssignmentMarks.AddOrUpdate(x => x.OralMark, m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20, m21,
                                                        m22, m23, m24, m25, m26, m27, m28, m29, m30, m31, m32, m33, m34, m35, m36, m37, m38, m39, m40, m41, m42, m43, m44,
                                                        m45, m46, m47, m48, m49, m50, m51, m52, m53, m54, m55, m56, m57, m58, m59, m60, m61, m62, m63, m64, m65, m66, m67,
                                                        m68, m69, m70, m71, m72, m73, m74, m75, m76, m77, m78, m79, m80, m81, m82, m83, m84, m85, m86, m87, m88, m89, m90,
                                                        m91, m92, m93, m94, m95, m96, m97, m98, m99, m100, m101, m102);
            context.Trainers.AddOrUpdate(x => x.LastName, t1, t2, t3, t4, t5, t6);
            context.Students.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30);
            context.Assignments.AddOrUpdate(x => x.Title, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15);
            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3, c4, c5);
            context.SaveChanges();

            #endregion
        }
    }
}
