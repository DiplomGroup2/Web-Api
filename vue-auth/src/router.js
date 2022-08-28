//import Vue from 'vue'
//import Router from 'vue-router'
//import { VueElement } from 'vue';
import {createWebHistory, createRouter} from 'vue-router';
import Home from './components/Home.vue'
import Login from './components/Login.vue'
import Register from './components/Register.vue'
//import Userpage from './components/Userpage.vue'
import Sp from './components/Sp.vue'
import Zerouserpage from './components/Zerouserpage.vue'
import TodoItem from './components/TodoItem.vue'
import Question from './components/Question.vue'


export default createRouter({
	history: createWebHistory(),
	routes: [
		{path: '/', component: Home},
		{path: '/login', component: Login},
		{path: '/register', component: Register},
		//{path: '/workspace', component: Userpage}
		{path: '/workspace', component: Sp},
		{path: '/zeroworkspace', component: Zerouserpage},
		{path: '/td', component: TodoItem},
		{path: '/question', component: Question}

	]
})










/*const routes = [
	{
		path: '/',
		name: 'Home',
		component: Home
	},

    {
		path: '/login',
		name: 'Login',
		component: Login
	},
    {
		path: '/register',
		name: 'Register',
		component: Register
	},
];

const router = createRouter({
	history: createWebHistory(),
	routes,
});

export default router;*/