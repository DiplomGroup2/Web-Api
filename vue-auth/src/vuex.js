import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex);

const state={
    user:null
};

const store=new Vuex.Store({
    state,
    getters:{
        username:(state)=>{
            return state.username;
        }
    },
    actions:{
        username(context,user){
            context.commit('user',username);
        }
    },
    mutations:{
        username(state,username){
            state.username=username;
        }
    }
});

export default store;