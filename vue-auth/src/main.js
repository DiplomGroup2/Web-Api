//import { createApp } from 'vue'
//import App from './App.vue'



//createApp(App).mount('#app')
//----------------------------------------

//import Vue from 'vue'
//import App from './App.vue'
//import router from './router'
import './axios'
//import store from './vuex'

//Vue.config.productionTip=false

//new Vue({
  //  router,
   // store,
   // render:h=>h(App),
//}).$mount('#app')



import { createApp } from 'vue'
import App from './App.vue'
import router from './router' // <---

createApp(App).use(router).mount('#app')