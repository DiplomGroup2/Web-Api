<template>
    <input type="hidden" id="anPageName" name="page" value="desktop-1" />
    <div class="container-center-horizontal">
      <div class="desktop-1 screen">
          <form @submit.prevent="handleSubmit">
              <div class="overlap-group5">
                  <error v-if="error" :error="error" />
                  <div class="rectangle-2 border-0-2px-gray"></div>
                  <div class="forgot-your-password">Forgot your password?</div>
                  <!--<div class="rectangle-4 border-0-4px-black">-->
                      <input type="email" class="form-control rectangle-4 border-0-4px-black" v-model="email" placeholder="Email" />

                  <!--</div>-->
                 <!-- <div class="rectangle-11 border-0-4px-black">-->
                      <input type="password" class="form-control rectangle-11 border-0-4px-black" v-model="password" placeholder="Password" />

                  <!--</div>-->
                  <!--<div class="email fredoka-light-nobel-16px">-->
                  <!--<label>Email</label>-->
                  <!--</div>-->
                  <!--<div class="password fredoka-light-nobel-16px">Password</div>-->
                  <div class="group-64">
                      <img class="vector-4"
                           src="../assets/vector-4-1@2x.svg" />
                  </div>
                  <div class="overlap-group1">
                      <div class="rectangle-3"></div>
                      <div class="overlap-group">
                          <img class="ellipse-1"
                               src="../assets/ellipse-1-4@2x.svg" />
                          <img class="ellipse-2"
                               src="../assets/ellipse-2-4@2x.svg" />
                          <img class="ellipse-3"
                               src="../assets/ellipse-3-4@2x.svg" />
                          <img class="ellipse-4"
                               src="../assets/ellipse-4-17@2x.svg" />
                          <img class="ellipse-5"
                               src="../assets/ellipse-5-4@2x.svg" />
                          <img class="vector"
                               src="../assets/vector-20@2x.svg" />
                          <img class="vector-1"
                               src="../assets/vector-21@2x.svg" />
                          <img class="vector-2"
                               src="../assets/vector-7@2x.svg" />
                      </div>
                      <div class="ellipse-6"></div>
                      <div class="ellipse-7"></div>
                  </div>
                  <div class="overlap-group2">
                      <div class="rectangle-6"></div>
                     <!-- <img class="icon-user" :src="require('@/assets/Profile.jpg')"/> -->
                     <img class="icon-user" src="../assets/mask-group-77@2x.svg"/>
                  </div>
                  <h1 class="title fredoka-bold-white-36px">Welcome!</h1>
                  <p class="we-provide-you-with fredoka-light-white-16px">
                      We provide you with a world of infinitely convenient notes. Make up your tasks for the day, a list of
                      products or a plan for working with a team in a couple of clicks!
                  </p>
                  <div class="overlap-group3 border-0-4px-white">
                      <div class="place fredoka-normal-white-20px" @click="FromSignInIntoRegister">Register</div>
                  </div>
                  <button class="btn btn-primary btn-block">
                      <!--Login-->

                      <div class="overlap-group4 border-0-4px-white">
                          <div class="sing-in fredoka-normal-white-20px">Sign in</div>
                      </div>
                  </button>
                  <div class="sing-in-1 fredoka-medium-black-30px">Sign in</div>
                  <p class="log-in-to-an-existin fredoka-light-black-16px">
                      Log in to an existing account so that your data cannot be lost
                  </p>
              </div>
          </form>
      </div>
    </div>
      <!--<img alt="Vue logo" src="./assets/logo.png">-->
      <!--<h3>Login</h3>-->
<!--<div class="form-group">
<label>Email</label>
<input type="email" class="form-control" v-model="login" placeholder="Email"/>
</div>

<div class="form-group">
<label>Password</label>
</div>-->


<!--<p class="forgot-password text-right">
<router-link to="forgot">Forgot password?</router-link>
</p>-->

</template>

<script>
import axios from 'axios'
import Error from './Error.vue'
export default {
    name:'LOGIN',
    x:'',
    components:{
        Error,
    },
    data(){
        return{
        email:'',
        password:'',
        error:''
        }
    },
    methods:{
        async handleSubmit()
        { try{
           const response=await axios.post('api/Account/Token',
           {
           email: this.email,
           password:this.password
           });
           localStorage.setItem('access_token',response.data.access_token);
           console.log(localStorage);
          
          
           alert(response.data.username);
        
           await this.$store.dispatch('user',response.data.username);

           //this.$store.dispatch('username',response.data.username);
           this.$router.push('/zeroworkspace');
           }catch(e){
            this.error = 'Invalid username/password!';
            console.log(e);
           }
        },
        FromSignInIntoRegister(){
          this.$router.push('/register');

        }
    }
    //ИЗМЕНЕНИЯ ПО СТИЛЮ . БЫЛО ВОТ ТАК:
   // .desktop-1 {
  //background-color: var(--baby-powder);
  //height: 910px;
  //width: 100%;
//}
}
</script>

<style>
.desktop-1 {
  /*background-color: var(--baby-powder);*/
   background-color:#e3e8ee;
  /*height: 10px;
  width: 130%; CТИЛЬ С ЗЕЛЕНЫМ ФОНОМ*/
  height:969px;
  width:1918px;
}

.desktop-1 .overlap-group5 {
  height: 655px;
  left: 460px;
  position: relative;
  top: 72px;
  width: 1139px;
}

.desktop-1 .rectangle-2 {
  background-color: var(--white);
  border-radius: 12px;
  box-shadow: 0px 7px 10px #00000040;
  height: 655px;
  left: 0;
  position: absolute;
  top: 0;
  width: 1051px;
}

.desktop-1 .forgot-your-password {
  color: #999999;
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xs);
  font-weight: 300;
  left: 193px;
  letter-spacing: 0;
  position: absolute;
  top: 412px;
  width: 124px;
}

.desktop-1 .rectangle-4 {
  -webkit-backdrop-filter: blur(15px) brightness(100%);
  backdrop-filter: blur(15px) brightness(100%);
  background-color: var(--white-32);
  border-radius: 13px;
  height: 48px;
  left: 99px;
  position: absolute;
  top: 276px;
  width: 313px;
}

.desktop-1 .rectangle-11 {
  -webkit-backdrop-filter: blur(15px) brightness(100%);
  backdrop-filter: blur(15px) brightness(100%);
  background-color: var(--white-32);
  border-radius: 13px;
  height: 48px;
  left: 99px;
  position: absolute;
  top: 352px;
  width: 313px;
}

.desktop-1 .email {
  left: 116px;
  letter-spacing: 0;
  position: absolute;
  top: 290px;
  width: 42px;
}

.desktop-1 .password {
  left: 117px;
  letter-spacing: 0;
  position: absolute;
  top: 365px;
  width: 73px;
}

.desktop-1 .group-64 {
  background-color: var(--white);
  height: 28px;
  left: 372px;
  position: absolute;
  top: 362px;
  width: 32px;
}

.desktop-1 .vector-4 {
  height: 10px;
  left: 6px;
  position: absolute;
  top: 10px;
  width: 21px;
}

.desktop-1 .overlap-group1 {
  height: 655px;
  left: 451px;
  position: absolute;
  top: 0;
  width: 688px;
}

.desktop-1 .rectangle-3 {
  /* Изменение в стиле фона*/
  background: linear-gradient(180deg, #74FDE0, #5BBCFD);
  border-radius: 0px 12px 12px 0px;
  height: 655px;
  left: 66px;
  position: absolute;
  top: 0;
  width: 533px;
}

.desktop-1 .overlap-group {
  height: 226px;
  left: 429px;
  position: absolute;
  top: 397px;
  width: 259px;
}

.desktop-1 .ellipse-1 {
  height: 223px;
  left: 0;
  position: absolute;
  top: 0;
  width: 259px;
}

.desktop-1 .ellipse-2 {
  height: 148px;
  left: 30px;
  position: absolute;
  top: 8px;
  width: 221px;
}

.desktop-1 .ellipse-3 {
  height: 203px;
  left: 31px;
  position: absolute;
  top: 23px;
  width: 203px;
}

.desktop-1 .ellipse-4 {
  height: 113px;
  left: 76px;
  position: absolute;
  top: 73px;
  width: 113px;
}

.desktop-1 .ellipse-5 {
  height: 167px;
  left: 49px;
  position: absolute;
  top: 45px;
  width: 161px;
}

.desktop-1 .vector {
  height: 27px;
  left: 103px;
  position: absolute;
  top: 100px;
  width: 29px;
}

.desktop-1 .vector-1 {
  height: 24px;
  left: 135px;
  position: absolute;
  top: 125px;
  width: 26px;
}

.desktop-1 .vector-2 {
  height: 42px;
  left: 116px;
  position: absolute;
  top: 104px;
  width: 37px;
}

.desktop-1 .ellipse-6 {
  -webkit-backdrop-filter: blur(10px) brightness(100%);
  backdrop-filter: blur(10px) brightness(100%);
  background: linear-gradient(180deg, rgb(255, 255, 255) 0%, rgba(255, 255, 255, 0) 100%);
  border-radius: 79.58px;
  box-shadow: 0px 4px 4px #eafffac2;
  height: 159px;
  left: 23px;
  position: absolute;
  top: 23px;
  transform: rotate(-159.22deg);
  width: 159px;
}

.desktop-1 .ellipse-7 {
  -webkit-backdrop-filter: blur(10px) brightness(100%);
  backdrop-filter: blur(10px) brightness(100%);
  background: linear-gradient(180deg, rgb(255, 255, 255) 0%, rgba(255, 255, 255, 0) 100%);
  border-radius: 50.34px;
  box-shadow: 0px 4px 4px #eafffac2;
  height: 101px;
  left: 17px;
  position: absolute;
  top: 107px;
  transform: rotate(-75.00deg);
  width: 101px;
}

.desktop-1 .overlap-group2 {
  height: 59px;
  left: 225px;
  position: absolute;
  top: 83px;
  width: 60px;
}

.desktop-1 .rectangle-6 {
  background: linear-gradient(180deg, rgba(248.63, 248.63, 248.63, 0) 0%, rgb(219.94, 236.07, 255) 100%);
  border-radius: 32.19px;
  height: 59px;
  left: 1px;
  position: absolute;
  top: 0;
  width: 59px;
}

.desktop-1 .icon-user {
  height: 59px;
  left: 0;
  position: absolute;
  top: 0;
  width: 59px;
}

.desktop-1 .title {
  left: 707px;
  letter-spacing: 0;
  position: absolute;
  top: 179px;
}

.desktop-1 .we-provide-you-with {
  left: 591px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 255px;
  width: 387px;
}

.desktop-1 .overlap-group3 {
  -webkit-backdrop-filter: blur(4px) brightness(100%);
  backdrop-filter: blur(4px) brightness(100%);
  background-color: var(--white-7);
  border-radius: 20px;
  height: 38px;
  left: 715px;
  position: absolute;
  top: 358px;
  width: 138px;
}

.desktop-1 .place {
  left: 32px;
  letter-spacing: 0;
  position: absolute;
  top: 5px;
}

.desktop-1 .overlap-group4 {
  -webkit-backdrop-filter: blur(4px) brightness(100%);
  backdrop-filter: blur(4px) brightness(100%);
  background-color: var(--malibu);
  border-radius: 20px;
  height: 38px;
  left: 186px;
  position: absolute;
  top: 459px;
  width: 138px;
}

.desktop-1 .sing-in {
  left: 39px;
  letter-spacing: 0;
  position: absolute;
  top: 5px;
}

.desktop-1 .sing-in-1 {
  left: 208px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 154px;
  width: 94px;
}

.desktop-1 .log-in-to-an-existin {
  left: 122px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 202px;
  width: 266px;
}

:root { 
  --baby-powder: #fcfcfc;
  --black: #000000;
  --gray: #919191;
  --malibu: #79a8f9;
  --nobel: #b5b5b5;
  --white: #ffffff;
  --white-32: #ffffff3b;
  --white-7: #ffffff33;
 
  --font-size-l: 20px;
  --font-size-m: 16px;
  --font-size-xs: 12px;
  --font-size-xxl: 36px;
  --font-size-xxl2: 30px;
 
  --font-family-fredoka: "Fredoka", Helvetica;
}
.fredoka-light-nobel-16px {
  color: var(--nobel);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-m);
  font-style: normal;
  font-weight: 300;
}

.fredoka-normal-white-20px {
  color: var(--white);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-l);
  font-style: normal;
  font-weight: 400;
}

.fredoka-bold-white-36px {
  color: var(--white);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxl);
  font-style: normal;
  font-weight: 700;
}

.fredoka-light-white-16px {
  color: var(--white);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-m);
  font-style: normal;
  font-weight: 300;
}

.fredoka-medium-black-30px {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxl2);
  font-style: normal;
  font-weight: 500;
}

.fredoka-light-black-16px {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-m);
  font-style: normal;
  font-weight: 300;
}

.border-0-4px-black {
  border: 0.4px solid var(--black);
}

.border-0-4px-white {
  border: 0.4px solid var(--white);
}

.border-0-2px-gray {
  border: 0.2px solid var(--gray);
}

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

</style>