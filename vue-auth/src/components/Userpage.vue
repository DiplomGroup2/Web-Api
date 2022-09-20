<template>
   <p> </p>       
</template>

<script>
import Userfront from "@userfront/core"
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
