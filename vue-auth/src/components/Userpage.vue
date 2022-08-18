<template>
    <!--<li>-->
    <!--{{ title }}
       <button id="logout-button" @click.prevent="handleLogout" >Log out</button>
              <h3 v-if="!username">You are not logged in!</h3>
              <h3 v-if="username" id="backgr">Hi,{{username}} </h3>



       <h3 ><font color="blue"> {{ title }} </font></h3>
        <error v-if="error" :error="error" />
        <img :src="require('@/assets/createpage.jpg')"/>

         <form v-on:submit.prevent="addNewTodo">
       <label for="new-todo">Add a todo</label>
       <input
         v-model="newTodoText"
         placeholder= "text"
       />
       <button>Add</button>
     </form>
    <button class="btn btn-primary btn-block">Create First Page</button>-->
    <!--</li>-->


   <p> </p>   
    <!--111111-->



   
   <!--<input type="hidden" id="anPageName" name="page" value="98_318" />
    <div class="group-15 border-0-4px-black"></div>-->
    
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

             components:{
        //Error

     },
             data(){
                return{
                    newTodoText: ''
                }
             },
             methods:{
            handleLogout() {
            console.log('log_out_button'),
            Userfront.logout();
            console.log('log_out_button2'),
            this.$router.push('/');
      },

    addNewTodo() {

         alert(this.newtodotext)

      }

    }
  }



</script>



<style scoped>

  </style>
