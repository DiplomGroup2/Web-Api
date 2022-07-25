
<template>

    <!--<h3 v-if="user">Hi,{{user.first_name}} {{user.last_name}} </h3>
    <h3 v-if="!user">You are not logged in!</h3>-->
    <!--<div class="example">hi</div>-->
   
    <div id="app">
    <!--<button type="button" @click="this.$router.push('/Register')">Register</button>-->
    <button type="button" @click="component='Register'">Register</button>
    <button type="button" @click="component='Login'">Login</button>
    <button type="button" @click="component='Home'">Home</button>
    <button type="button" @click="component='Sp'">Spisok</button>
    <!-- <button type="button" @click="component='Login'">Login</button> -->
    
    <keep-alive>
      <component :is="component"></component>
    </keep-alive>
  </div>

    <div class="back">
    <h3 v-if="!username">You are not logged in!</h3>
    <h3 v-if="username">Hi,{{username}} </h3>
    </div>

</template>

<script>

import {mapGetters} from 'vuex'
import Login from './Login';
import Register from './Register';
import Home from './Home';
import Sp from './Sp';

export default {
    name:'HOME',
    
    computed: {
        ...mapGetters(['username'])
    },
    components:{
        Login,
        Register,
        Home,
        Sp
    },
    data(){
                return{  
                    // return: "",                  
                    component:'Home'
                    
                }
             },
}
</script>
<style>

/* @import url('https://fonts.googleapis.com/css?family=Fira+Sans:400,500,600,700,800');
*{
  box-sizing:border-box;
} */

body{
  background:white;  
  min-height:100vh;
  display:flex;
  font-weight:400;
  font-family:'Fira Sans', sand-serif;
}

/* h1,h2,h3,h4,h5,h6,label,span{
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

