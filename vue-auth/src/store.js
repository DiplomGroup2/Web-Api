//import Vue from 'vue'
//import Vuex from 'vuex'
import { createStore } from 'vuex'

//Vue.use(Vuex);



export default createStore({
    state : {
        username:''
    },

    getters:{
        username:(state)=>{
            //alert("username");
            return state.username;
        }
    },
    actions:{
        user: (context,username)=>{
            //alert("commit");
            context.commit('user',username);
        }
    },
    mutations:{
        user:(state,username)=>{
           // alert("mutation");
            state.username=username;
        }
    }
});
