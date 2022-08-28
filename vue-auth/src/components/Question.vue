<template > 
<li>
       <!--ВЫВОД СТРОКИ,КТО ПОДКЛЮЧИЛСЯ , ТАКЖЕ НУЖНО  РАСКОММЕНТИРОВАТЬ Я КОМПОНЕНТ ERROR-->
       <!--{{ title }}
           <h3 v-if="!username" id="backgr">You are not logged in!</h3>
           <h3 v-if="username" id="backgr">Hi,{{username}} </h3>
    <h3 ><font color="blue"> {{ title }} </font></h3>     
     <error v-if="error" :error="error" />   -->
     




      <input type="hidden" id="anPageName" name="page" value="desktop-7" />
    <div class="container-center-horizontal">
      <div class="desktop-7 screen">
        <div class="overlap-group1">
          <div class="ellipse-3"></div>
          <div class="ellipse-5"></div>
          <div class="ellipse-6"></div>
          <img
            class="ellipse-4" src="../assets/ellipse-4-13@2x.svg"
          />
          
          <div class="rectangle-24 border-2px-white"></div>
           
          <img
            class="line-1" src="../assets/line-1-10@1x.svg"
          />
          <div class="overlap-group border-0-4px-white">
           
            <div class="creat-first-page fredoka-normal-white-20px"><button @click="Workspace" style="background-color: transparent; border-color: transparent; width:150px">Personal pages</button></div>
          </div>
          <div class="questions">
          <img
            class="group-18" src="../assets/group-18-10@2x.svg"
          />
          <h1 class="place fredoka-medium-black-30px">QUESTIONS</h1>
          <div class="shall-we-start-by-cr fredoka-light-black-30px">
            Are you creating a page in our site for the first time?
            <p>See the answers for some important questions.</p> 
          </div>
          <div class="shall-we-start-by-cr1 fredoka-light-black-30px1">
            What is xTiles? 
          </div>
          <div class="shall-we-start-by-cr2 fredoka-light-black-30px1">
            xTiles is a cross-platform visual note-taking app for creative people . It helps creative minds gather and store their thoughts in one place.
          </div>
          <div class="shall-we-start-by-cr3 fredoka-light-black-30px1">
            What are the most common uses for xTiles ?
          </div>
          <div class="shall-we-start-by-cr4 fredoka-light-black-30px1">
            <p>- creative writing;</p>
            <p>- note-taking;</p>
            <p>- personal productivity;</p>
            <p>- remote working;</p>
            <p>- researching;</p>
          </div>
          <div class="shall-we-start-by-cr5 fredoka-light-black-30px1">
          What are Key benefits of using xTiles?
          </div>
          <div class="shall-we-start-by-cr6 fredoka-light-black-30px1">
            <p> - Easy to use and flexible approach for creative processes;</p>
            <p> - One-click publishing to the web;</p>
            <p> - All your notes are in one place</p>
            </div>
          </div>
          
          <!--<div class="rectangle-70"></div>
          <div class="rectangle-73"></div>
          <div class="rectangle-71"></div>
          <div class="rectangle-72"></div>-->
        </div>
        <!--<img
          class="mask-group" src="../assets/mask-group-63@1x.svg"
        />-->
        <!--<img
          class="x1" src="../assets/---1@1x.png"
        />-->
        <div class="ellipse-7"></div>
        <div class="ellipse-8"></div>
        <!--<img
          class="ellipse-9" src="../assets/ellipse-9@2x.svg"
        />
        <img
          class="ellipse-10" src="../assets/ellipse-10@2x.svg"
        />
        <img
          class="icon-light_bulb" src="../assets/mask-group-64@2x.svg"
        />-->
        <div class="group-10">
          <!--<div class="overlap-group-1">
            <div class="rectangle-9 border-0-3px-fresh-air"></div>
            <div class="text-1 fredoka-bold-white-30px" @click="QuestionPage">?</div>
          </div>
          <div class="group-12 border-0-3px-fresh-air">
            <img
              class="icon-star"
              src="../assets/star-1-10@2x.svg"
            />
          </div>
          <div class="group-13 border-0-3px-fresh-air">
            <img
              class="mask-group-1"
              src="../assets/mask-group-66@2x.svg"
            />
          </div>-->
          <div class="group-14 border-0-3px-fresh-air" id="outtooltip" >
            <img 
              class="icon-user" @click="handleLogout"
              src="../assets/mask-group-84@2x.svg"
            />
            <span id="tooltiptext" @click="handleLogout">Log out</span>
          </div>
        </div>
      </div>
    </div>
     
     <!--  <form v-on:submit.prevent="addNewTodo">
    <label for="new-todo">Add a todo</label>
    <input
      v-model="newTodoText"
      placeholder= "text"
    />
    <button>Add</button>
  </form>
-->
      <!--<button class="btn btn-primary btn-block"  @click="Workspace">Create First Page</button> -->
   </li>
   
</template>


<script>
//import axios from 'axios'
//import {mapGetters} from 'vuex'
import Userfront from "@userfront/core"
//import Error from './Error.vue'
import {mapGetters} from 'vuex'



Userfront.init("demo1234");

    export default 
    {
             name:'USERPAGE',
             props: ['title'],
             
   
             computed: {
        ...mapGetters(['username']),
        isLoggedOut() {
       return !Userfront.tokens.accessToken;
    },
            },
             
             //components:{
        //Error
        
     //},
             data(){
                return{   
                    return: ''                 
                     
                    
                }
             },
             methods:{           
            handleLogout() {
            console.log('log_out_button'),  
            Userfront.logout();
            console.log('log_out_button2'),  
            this.$router.push('/');
      }, Workspace(){
        this.$router.push('/workspace');
      },
      QuestionPage(){
          this.$router.push('/question');
      },
        
    
     
    },
  }
    
    
    
</script>



<style scoped>

.desktop7.questions{
  padding-left: 300px;
}
#outtooltip {
  position: relative;
  display: inline-block;
  
}
#outtooltip #tooltiptext {
  visibility: hidden;
  width: 120px;
  background-color: rgba(0, 0, 0, 0.322);
  color: #fff;
  text-align: center;
  border-radius: 6px;
  border-color: black;
  padding: 5px 0;

  /* Position the tooltip */
  position: absolute;
  z-index: 1;
}

#outtooltip:hover #tooltiptext {
  visibility: visible;
  cursor: pointer;
}


.desktop-7 {
  align-items: flex-start;
  
  background-color: #e3e8ee;
  display: flex;
  height: 747px;
  margin-top:-17px;
  /*height: 1024px;*/
  overflow: hidden;
  /*width: 1440px;*/
  width: 1519px;
}

.desktop-7 .overlap-group1 {
  height: 1118px;
  margin-left: -88px;
  margin-top: -94.24px;
  position: relative;
  width: 1678px;
  z-index: 1;
}

.desktop-7 .ellipse-3 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 179.63px;
  height: 359px;
  left: 37px;
  position: absolute;
  top: 37px;
  transform: rotate(-13.71deg);
  width: 420px;
}


.desktop-7 .ellipse-5 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 143.16px;
  height: 286px;
  left: 1239px;
  position: absolute;
  top: 590px;
  transform: rotate(-120.00deg);
  width: 386px;
}

.desktop-7 .ellipse-6 {
  background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
  border-radius: 117.04px;
  height: 234px;
  left: 1352px;
  position: absolute;
  top: 421px;
  transform: rotate(-60.00deg);
  width: 234px;
}

.desktop-7 .ellipse-4 {
  height: 359px;
  left: 50px;
  position: absolute;
  top: 196px;
  width: 459px;
}

.desktop-7 .rectangle-24 {
  -webkit-backdrop-filter: blur(15px) brightness(100%);
  backdrop-filter: blur(15px) brightness(100%);
  
  background-color:var(--white-4);
  border-radius: 13px;
  /*height: 1024px;*/
  height: 730px;
  margin-top:5px;
  /*left: 109px;*/
  left: 140px;
  position: absolute;
  top: 94px;
  width: 1402px;
}

.desktop-7 .line-1 {
  height: 1px;
  left: 171px;
  position: absolute;
  top: 159px;
  width: 1316px;
}

.desktop-7 .overlap-group {
  -webkit-backdrop-filter: blur(4px) brightness(100%);
  align-items: flex-start;
  backdrop-filter: blur(4px) brightness(100%);
  background-color: var(--malibu);
  border-radius: 20px;
  display: flex;
  height: 37px;
  left: 750px;
  min-width: 275px;
  padding: 5.3px 65.3px;
  position: absolute;
  top: 750px;
}

.desktop-7 .creat-first-page {
  letter-spacing: 0;
  min-height: 24px;
  width: 154px;
  
  
}

.desktop-7 .group-18 {
  height: 82px;
  left: 474px;
  position: absolute;
  top: 197px;
  width: 82px;
}

.desktop-7 .place {
  left: 800px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 215px;
  width: 160px;
  color: #8d5cff;
}

.desktop-7 .shall-we-start-by-cr {
  left: 580px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 300px;
  width: 650px;
  color: #5c6cff;
  font-weight: bold;
}

.desktop-7 .shall-we-start-by-cr1 {
  left: 820px;
  letter-spacing: 0;
  position: absolute;
  text-align: left;
  top: 400px;
  width: 650px;
  font-weight: bold;
  color:#8d5cff;
  font-size:23px;
}

.desktop-7 .shall-we-start-by-cr2 {
  left: 580px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 430px;
 width: 650px;
 font-weight: normal;
}

.desktop-7 .shall-we-start-by-cr3 {
  left: 570px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 480px;
  width: 650px;
  font-weight: bold;
  color:#8d5cff;
  font-size:23px;
}

.desktop-7 .shall-we-start-by-cr4 {
  left: 560px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 500px;
  width: 650px;
   font-weight: normal;
}

.desktop-7 .shall-we-start-by-cr5 {
  left: 570px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 615px;
  width: 650px;
  font-weight: bold;
  color:#8d5cff;
  font-size:23px;
}

.desktop-7 .shall-we-start-by-cr6 {
  left: 560px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  top: 640px;
  width: 650px;
  font-weight: normal;
}
.desktop-7 .rectangle-70 {
  background: linear-gradient(180deg, rgb(55.25, 111.18, 255) 0%, rgba(255, 255, 255, 0) 100%);
  border-radius: 18.92px;
  height: 132px;
  left: 968px;
  position: absolute;
  top: 241px;
  transform: rotate(-30.00deg);
  width: 13px;
}

.desktop-7 .rectangle-73 {
  background: linear-gradient(180deg, rgb(55.25, 111.18, 255) 0%, rgba(255, 255, 255, 0) 100%);
  border-radius: 18.92px;
  height: 35px;
  left: 1177px;
  position: absolute;
  top: 673px;
  transform: rotate(-30.00deg);
  width: 13px;
}

.desktop-7 .rectangle-71 {
  background: linear-gradient(180deg, rgb(215.65, 124.81, 247.56) 0%, rgba(255, 255, 255, 0) 100%);
  border-radius: 18.92px;
  height: 132px;
  left: 1151px;
  position: absolute;
  top: 630px;
  transform: rotate(-30.00deg);
  width: 13px;
}

.desktop-7 .rectangle-72 {
  background: linear-gradient(180deg, rgb(215.65, 124.81, 247.56) 0%, rgba(255, 255, 255, 0) 100%);
  border-radius: 18.92px;
  height: 24px;
  left: 962px;
  position: absolute;
  top: 268px;
  transform: rotate(-30.00deg);
  width: 13px;
}

.desktop-7 .mask-group {
  height: 677px;
  left: 693px;
  position: fixed;
  top: 53px;
  width: 577px;
  z-index: 2;
}

.desktop-7 .x1 {
  height: 537px;
  left: 794px;
  object-fit: cover;
  position: fixed;
  top: 132px;
  width: 537px;
  z-index: 7;
}

.desktop-7 .ellipse-7 {
  background-color: var(--white-5);
  border-radius: 101.89px;
  height: 204px;
  left: 796px;
  position: fixed;
  top: 427px;
  width: 204px;
  z-index: 3;
}

.desktop-7 .ellipse-8 {
  background-color: var(--white-5);
  border-radius: 72.87px;
  height: 146px;
  left: 825px;
  position: fixed;
  top: 456px;
  width: 146px;
  z-index: 4;
}

.desktop-7 .ellipse-9 {
  height: 97px;
  left: 990px;
  position: fixed;
  top: 126px;
  width: 146px;
  z-index: 5;
}

.desktop-7 .ellipse-10 {
  height: 88px;
  left: 1019px;
  position: fixed;
  top: 155px;
  width: 88px;
  z-index: 6;
}

.desktop-7 .icon-light_bulb {
  height: 44px;
  left: 1041px;
  position: fixed;
  top: 177px;
  width: 44px;
  z-index: 9;
}

.desktop-7 .group-10 {
  align-items: center;
  box-shadow: 0px 2px 2px #5c8aff;
  display: flex;
  height: 65px;
  left: 1134px;
  min-width: 80px;
  position: fixed;
  top: 65px;
  z-index: 8;
}

.desktop-7 .overlap-group-1 {
  height: 36px;
  position: relative;
  width: 32px;
}

.desktop-7 .rectangle-9 {
  background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);
  border-radius: 13px;
  height: 32px;
  left: 0;
  position: absolute;
  top: 2px;
  width: 32px;
}

.desktop-7 .text-1 {
  -webkit-background-clip: text !important;
  -webkit-text-fill-color: transparent;
  background: linear-gradient(180deg, rgb(39.91, 92.81, 195.5) 0%, rgba(107.09, 43.24, 157.25, 0) 100%);
  background-clip: text;
  left: 8px;
  letter-spacing: 0;
  position: absolute;
  text-align: center;
  text-fill-color: transparent;
  top: 0;
}

.desktop-7 .group-12 {
  align-items: flex-start;
  background: linear-gradient(180deg, rgba(246, 246, 249, 0.27) 0%, rgb(255, 255, 255) 0.01%, rgb(232, 241, 253) 100%);
  border-radius: 13px;
  display: flex;
  height: 32px;
  margin-left: 12px;
  margin-top: 0;
  min-width: 32px;
  padding: 5.7px 5.2px;
}

.desktop-7 .icon-star {
  height: 20px;
  width: 21px;
}

.desktop-7 .group-13 {
  align-items: flex-start;
  background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);
  border-radius: 13px;
  display: flex;
  height: 32px;
  margin-left: 12px;
  min-width: 32px;
  padding: 6.4px 5.8px;
}

.desktop-7 .mask-group-1 {
  height: 19px;
  width: 20px;
}

.desktop-7 .group-14 {
  align-items: flex-end;
  background: linear-gradient(180deg, rgba(248.63, 248.63, 248.63, 0) 0%, rgb(219.94, 236.07, 255) 100%);
  border-radius: 13px;
  cursor: pointer;
  display: flex;
  justify-content: flex-end;
  margin-left: 13px;
  min-width: 32px;
}

.desktop-7 .icon-user {
  height: 60px;
 
  width: 60px;
  cursor:pointer;

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

.overlay {
  display: none;
  height: 100%;
  opacity: 0;
  position: fixed;
  top: 0;
  width: 100%;
}

.overlay.animate-appear {
  animation: reveal 0.3s ease-in-out 1 normal forwards;
  display: block;
  opacity: 0;
}

.overlay.animate-disappear {
  animation: reveal 0.3s ease-in-out 1 reverse forwards;
  display: block;
  opacity: 1;
  pointer-events: none;
}

.overlay.animate-disappear * {
  pointer-events: none;
}

* {
  box-sizing: border-box;
}

:root { 
  --black: #000000;
  --fresh-air: #aed8ff73;
  --malibu: #79a8f9;
  --mystic: #e3e8ee;
  --white: #ffffff;
  --white-4: #ffffffb2;
  --white-5: #ffffff69;
 
  --font-size-xxl: 30px;
 
  --font-family-fredoka: "Fredoka", Helvetica;
}
.fredoka-normal-white-20px {
  color: var(--white);
  font-family: var(--font-family-fredoka);
  font-size: 19px;
  font-style: normal;
  font-weight: 400;
}

.fredoka-medium-black-30px {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxl);
  font-style: normal;
  font-weight: 500;
}

.fredoka-light-black-30px {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: 25px;
  font-style: normal;
  font-weight: 300;
}

.fredoka-light-black-30px1 {
  color: var(--black);
  font-family: var(--font-family-fredoka);
  font-size: 20px;
  font-style: normal;
  font-weight: 200;
}

.fredoka-bold-white-30px {
  font-family: var(--font-family-fredoka);
  font-size: var(--font-size-xxl);
  font-style: normal;
  font-weight: 700;
}

.border-0-3px-fresh-air {
  border: 0.3px solid var(--fresh-air);
}

.border-2px-white {
  border: 2px solid var(--white);
}

.border-0-4px-white {
  border: 0.4px solid var(--white);
}


  #logout-button {
    background-color: rgb(0, 149, 255);
    color: white;
    border: none;
    
    width:100px;
    border: 2px solid red;
    margin:auto;
    display:grid;
  padding: 10px;
  border-radius: 50px 20px;
    
    
  }
  #backgr{
    text-align: center;
    background-color: aqua;
    margin-top:5px;
    margin-bottom: 5px;
    padding:5px 8px;
    font-size: large;
    font-weight: bold;
  }
  #logout-button[disabled] {
    background-color: lightgray;
    color: gray;
  }
</style>
