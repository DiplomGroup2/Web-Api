
<template>
  <input type="hidden" id="anPageName" name="page" value="desktop-25" />
    <div class="container-center-horizontal">
      <div class="desktop-25 screen">
        <div class="overlap-group2">
          <div class="ellipse-3"></div>
          <div class="ellipse-5"></div>
          <div class="ellipse-6"></div>
          <img
            class="ellipse-4" src="../assets/ellipse-4@2x.svg"
          />
          

          <img
            class="rectangle-24" src="../assets/rectangle-24@1x.png"
          />
          
          
          <!--<div class="overlap-group border-0-4px-white"><div class="place fredoka-normal-white-20px" @click="component='Register'">Start</div></div>-->
          <div class="overlap-group border-0-4px-white"><div class="place fredoka-normal-white-20px" @click="RegisterClick">Start</div></div>-->
          
          <div class="group-72">
            <div class="overlap-group1 border-0-4px-white">
              <div class="place-1 fredoka-normal-white-20px" @click="RegisterClick">Register</div>
            </div>
          </div>
          
          <div class="sing-in" @click="SignInClick">Sign in</div>
          <img
            class="group-18" src="../assets/group-18@2x.svg"
          />
          
          <div class="tiles" id="outtooltip">tiles

          <!-- <span id="tooltiptext"><h3 v-if="!username">You are not logged in!</h3>
                                  <h3 v-if="username">Hi,{{username}} </h3></span>-->
          </div>
              
           
          <div class="organize-your-ideas-projects-visually">Organize your ideas &amp; projects visually</div>
          <div class="personal-workspace-favored-by-creatives">Personal workspace favored by creatives</div>
          <div class="rectangle-136">
            <!--<iframe width="700" height="415"
             src="https://www.youtube.com/embed/1bvqFU5OhWQ" 
             title="YouTube video player"
              frameborder="0" 
              allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
               allowfullscreen></iframe>-->
               <iframe width="700" height="415" 
               src="https://www.youtube.com/embed/H7bOtuZtiXk" 
               title="YouTube video player"
                frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
          </div>
         <!--<img
            class="polygon-1" src="../assets/polygon-1@2x.svg"
          />-->
          <div class="ellipse-7"></div>
          <div class="ellipse-8"></div>
          <img
            class="rectangle-137" src="../assets/rectangle-137@1x.png"
          />
          
          <div class="copyright fredoka-normal-black-20px">© 2022 xTiles</div>
          <div class="privacy-policy fredoka-light-white-15px">Privacy policy</div>
          <div class="public-offer fredoka-light-white-15px">Public offer</div>
          <div class="cookies fredoka-light-white-15px">Cookies</div>
          <img
            class="group-73" src="../assets/group-73@2x.svg"
          />

          <h1 class="title">tiles</h1>
        </div>
      </div>
    </div>
    <!--<h3 v-if="user">Hi,{{user.first_name}} {{user.last_name}} </h3>
    <h3 v-if="!user">You are not logged in!</h3>-->
    <!--<div class="example">hi</div>-->
   
    <div id="app">
    <!--<button type="button" @click="this.$router.push('/Register')">Register</button>-->
    <!-- ЗАКРЫТЫЕ КНОПКИ ! -->
    <!--<button type="button" @click="component='Register'">Register</button>
    <button type="button" @click="component='Login'">Login</button>
    <button type="button" @click="component='Home'">Home</button>
    <button type="button" @click="component='Sp'">Spisok</button>-->

    <!-- <button type="button" @click="component='Login'">Login</button> -->
    <!-- ДЛЯ ПОДКЛЮЧЕНИЯ ДИНАМИЧЕСКИ:    
    <keep-alive>
      <component :is="component"></component>
    </keep-alive>-->
  </div>

    <!--<div class="back">
    <h3 v-if="!username">You are not logged in!</h3>
    <h3 v-if="username">Hi,{{username}} </h3>
    </div>-->

</template>

<script>

export default 
    {
      name:'HOME',
      methods:{ 
        SignInClick(){
             this.$router.push('/login');

        },
        RegisterClick(){
          this.$router.push('/register');
        }
      }


    }
// - МОЖЕТ ПРИГОДИТЬСЯ. через мапирование остаемся на той же странице
//import {mapGetters} from 'vuex'
//import Login from './Login';

//import Register from './Register';
//import Home from './Home';
//import Sp from './Sp';

//export default {
    //name:'HOME',
    
    //computed: {
       // ...mapGetters(['username'])
   // },
   // components:{
     //   Login,
        //Register,
       // Home,
       //Sp
    //},
    //data(){
               // return{  
                    // return: "",                  
                   // component:'Home'
                    
                //}
             //},

//}





</script>
<style  scoped>
#outtooltip {
  position: relative;
  display: inline-block;
  
}
#outtooltip #tooltiptext {
  
  width: 300px;
  background-color: lightskyblue;
  color: darkblue;
  text-align: center;
  border-radius: 20px;
  margin-left: 10px;
  padding: 5px 5px;
  visibility: visible;
  /* Position the tooltip */
  position: absolute;
  z-index: 1;
}



/* @import url('https://fonts.googleapis.com/css?family=Fira+Sans:400,500,600,700,800');
*{
  box-sizing:border-box;
} */
@import url("https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css");

@import url("https://fonts.googleapis.com/css?family=Fredoka:400,300,700,500");

.screen a {
  display: contents;
  text-decoration: none;
}

.container-center-horizontal {
  display: flex;
  flex-direction: row;
  justify-content: center;
  pointer-events: none;
  width: 100%;
}

.container-center-horizontal > * {
  flex-shrink: 0;
  pointer-events: auto;
}

* {
  box-sizing: border-box;
}

:root { 
  --black: #000000;
  --malibu: #79a8f9;
  --mystic: #e3e8ee;
  --white: #ffffff;
  --white-4: #ffffffb2;
 
  --font-size-l: 22.7px;
  --font-size-s: 15px;
  --font-size-xl: 33px;
  --font-size-xl2: 20px;
  --font-size-xxl: 35.8px;
 
  --font-family-fredoka: "Fredoka", Helvetica;
}
.fredoka-light-white-15px {
  color: var(--white);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-s);
  font-style: normal;
  font-weight: 300;
}

.fredoka-normal-white-20px {
  color: var(--white);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-style: normal;
  font-weight: 400;
  cursor:pointer;
}

.fredoka-normal-black-20px {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-style: normal;
  font-weight: 400;
}

.border-0-4px-white {
  border: 0.4px solid var(--white);
}


.desktop-25 {
  align-items: flex-start;
  /*background-color: var(--mystic);
  background-color:lightblue;*/
   background-color: #e3e8ee;
  display: flex;
  overflow: hidden;
  /*width: 1440px;*/
  width: 1520px;
  
}

.desktop-25 .overlap-group2 {
  height: 1066px;
  margin-left: -89px;
  position: relative;
  width: 1529px;
}

.desktop-25 .ellipse-3 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 179.63px;
  height: 359px;
  left: 37px;
  position: absolute;
  top: 53px;
  transform: rotate(13.71deg);
  width: 359px;
}

.desktop-25 .ellipse-5 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 143.16px;
  height: 286px;
  left: 534px;
  position: absolute;
  top: 382px;
  transform: rotate(60.00deg);
  width: 286px;
}

.desktop-25 .ellipse-6 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 117.04px;
  height: 234px;
  left: 674px;
  position: absolute;
  top: 303px;
  transform: rotate(120.00deg);
  width: 234px;
}

.desktop-25 .ellipse-4 {
  height: 359px;
  left: 89px;
  position: absolute;
  top: 211px;
  width: 258px;
}

.desktop-25 .rectangle-24 {
  height: 750px;
  /*height: 1066px;*/
  left: 150px;
  top: 20px;
  width: 1402px;
  position: absolute;
  
   
}

.desktop-25 .overlap-group {
  -webkit-backdrop-filter: blur(4px) brightness(100%);
  align-items: flex-start;
  backdrop-filter: blur(4px) brightness(100%);
  background-color: var(--malibu);
  border-radius: 20px;
  display: flex;
  height: 37px;
  left: 395px;
  min-width: 124px;
  padding: 5.3px 37.0px;
  position: absolute;
  top: 381px;
}

.desktop-25 .place {
  letter-spacing: 0;
  min-height: 24px;
  text-align: center;
  width: 49px;
}

.desktop-25 .group-72 {
  align-items: flex-start;
  cursor: pointer;
  display: flex;
  height: 37px;
  left: 1223px;
  min-width: 169px;
  position: absolute;
  top: 22px;
}

.desktop-25 .overlap-group1 {
  -webkit-backdrop-filter: blur(4px) brightness(100%);
  align-items: flex-start;
  backdrop-filter: blur(4px) brightness(100%);
  background-color: var(--malibu);
  border-radius: 20px;
  display: flex;
  height: 37px;
  min-width: 167px;
  padding: 5.3px 43.9px;
}

.desktop-25 .place-1 {
  letter-spacing: 0;
  min-height: 24px;
  text-align: center;
  width: 78px;
}

.desktop-25 .sing-in {
  color: var(--malibu);
  cursor: pointer;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-weight: 400;
  left: 1143px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 27px;
  width: 78px;
}

.desktop-25.sing-inn{
  color: var(--malibu);
  cursor: pointer;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-weight: 400;
  left: 2000px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 27px;
  width: 78px;
}

.desktop-25 .group-18 {
  height: 70px;
  left: 220px;
  position: absolute;
  top: 45px;

  width: 70px;
}

.desktop-25 .tiles {
  color: #0a54e2;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-l);
  font-weight: 500;
  left: 280px;
  letter-spacing: 0;
  position: absolute;
  top: 90px;
  width: 49px;
}

.desktop-25 .organize-your-ideas-projects-visually {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl);
  font-weight: 400;
  left: 286px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 238px;
  width: 344px;
}

.desktop-25 .personal-workspace-favored-by-creatives {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xl2);
  font-weight: 300;
  left: 269px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 324px;
  width: 377px;
}

.desktop-25 .rectangle-136 {
  background-color: var(--white);
  border-radius: 12px;
  box-shadow: 0px 4px 0px #8ba8de;
  height: 409px;
  left: 695px;
  position: absolute;
  top: 139px;
  width: 695px;
}

/*.desktop-25 .polygon-1 {
  height: 82px;
  left: 1016px;
  position: absolute;
  top: 298px;
  width: 72px;
}*/

.desktop-25 .ellipse-7 {
  -webkit-backdrop-filter: blur(10px) brightness(100%);
  backdrop-filter: blur(10px) brightness(100%);
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 91.52px;
  height: 183px;
  left: 1279px;
  position: absolute;
  top: 96px;
  transform: rotate(-63.00deg);
  width: 183px;
}

.desktop-25 .ellipse-8 {
  -webkit-backdrop-filter: blur(10px) brightness(100%);
  backdrop-filter: blur(10px) brightness(100%);
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 44.95px;
  height: 90px;
  left: 1397px;
  position: absolute;
  top: 224px;
  transform: rotate(-10.02deg);
  width: 90px;
}

.desktop-25 .rectangle-137 {
  height: 422px;
  
  left: 91px;
  position: absolute;
  top: 644px;
  /*width: 1439px;*/
  width: 1515px;
}

.desktop-25 .copyright {
  left: 234px;
  letter-spacing: 0;
  position: absolute;
  top: 948px;
  width: 140px;
}

.desktop-25 .privacy-policy {
  left: 433px;
  letter-spacing: 0;
  position: absolute;
  top: 950px;
  width: 99px;
}

.desktop-25 .public-offer {
  left: 562px;
  letter-spacing: 0;
  position: absolute;
  top: 950px;
  width: 77px;
}

.desktop-25 .cookies {
  left: 669px;
  letter-spacing: 0;
  position: absolute;
  top: 951px;
  width: 58px;
}

.desktop-25 .group-73 {
  height: 51px;
  left: 229px;
  position: absolute;
  top: 845px;
  width: 51px;
}

.desktop-25 .title {
  color: #0a54e2;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxl);
  font-weight: 500;
  left: 287px;
  letter-spacing: 0;
  position: absolute;
  top: 846px;
  width: 78px;
}

.desktop-25.back{
    background-color: aquamarine;
}
/* 

body{
  background:white;  
  min-height:100vh;
  display:flex;
  font-weight:400;
  font-family:'Fira Sans', sand-serif;
}


h1,h2,h3,h4,h5,h6,label,span{
  font-weight:500;
  font-family:'Fira Sans',sans-serif;
}

body,html, #app, #root,.auth-wrapper{
  width:100%;
  height:100%;
}

#app{
  text-align:center;
}
.navbar-light{
  background-color:#ffffff;
  box-shadow:0px 14px 80px rgba(34,35,58,0.2);
}

.auth-wrapper{
  display:flex;
  justify-content:center;
  flex-direction:column;
  text-align:left;
}
.auth-inner{
  width:450px;
  margin:auto;
  background:#ffffff;
  box-shadow:0px 14px 80px rgba(34,35,58,0.2);
  padding:40px 55px 45px 55px;
  border-radius:15px;
  transition:all .3s;

}

.auth-wrapper .form-control:focus{
  border-color: #167bff; 
  box-shadow:none;
}

.auth-wrapper h3{
  text-align:center;
  margin:0;
  line-height:1;
  padding-bottom:20px;

}

.custom-control-label{
  font-weight:400;

}

.forgot-password,
.forgot-password a {
  text-align:right;
  font-size:13px;
  padding-top: 10px;
  color:#7f7d7d;
  margin:0;
} */

/* .forgot-password a {
  /* color:#167bff; */

/* } */
</style>


<!-- <style scoped>
.example {
  color: red;
}
.back{
    background-color: aquamarine;
}
body{
  background:white;
  min-height:100vh;
  display:flex;
  font-weight:400;
  font-family:'Fira Sans', sand-serif;
}
.auth-wrapper .form-control:focus{
  border-color: #d0ff16;
  box-shadow:none;
}
</style> -->

