<template>

    <input type="hidden" id="anPageName" name="page" value="desktop-11" />
    <div class="container-center-horizontal">
        <div class="desktop-11 screen">
            <div class="overlap-group7">
                <div class="ellipse-3"></div>
                <div class="ellipse-5"></div>
                <div class="ellipse-6"></div>
                <img class="ellipse-4"
                     src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/ellipse-4-6@2x.svg" />
                <div class="rectangle-24 border-2px-white">
                    <div class=" border-2px-white" style=" margin-top: 150px; margin-left: 330px;">
                        <!--<ul>-->
                        <div class="group-15 border-0-4px-black" v-on:click="addNewTodo">
                            <div class="overlap-group3" >
                                <div class="rectangle-14 border-0-4px-white"></div>
                                <div class="rectangle-15 border-0-4px-white"></div>
                            </div>
                        </div>
                        <todo-item v-for="(todo) in todos"
                                   :title="todo.title"
                                   :key="todo.id"
                                   @remove="todos.splice(index, 1)"></todo-item>
                        <!--</ul>-->
                    </div>
                </div>
                <img class="line-1"
                     src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/line-1@1x.svg" />
                <img class="line-2"
                     src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/line-2-2@1x.svg" />
                <img class="group-18"
                     src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/group-18-3@2x.svg" />
                <h1 class="title fredoka-medium-black-25px">Personal Pages</h1>
                <!--<ul>
                    <todo-item v-for="(todo) in todos"
                               :title="todo.title"
                               :key="todo.id"
                               @remove="todos.splice(index, 1)"></todo-item>
                </ul>-->
                <div class="overlap-group1">
                    <div class="rectangle-12"></div>
                    <div class="fix fredoka-light-black-16px">Fix</div>
                    <div class="group-container">
                        <img class="group-23"
                             src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/group-23-4@2x.svg" />
                        <img class="group-24"
                             src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/group-24-3@2x.svg" />
                    </div>
                </div>
                <div class="overlap-group2">
                    <div class="group-container-1">
                        <div class="overlap-group">
                            <div class="group-67">
                                <img class="vector-1"
                                     src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/vector-1-7@2x.svg" />
                                <img class="vector"
                                     src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/vector-2-7@2x.svg" />
                                <img class="vector"
                                     src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/vector-3-6@2x.svg" />
                            </div>
                            <img class="rectangle-36"
                                 src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/rectangle-36-6@2x.svg" />
                        </div>
                        <img class="mask-group"
                             src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/mask-group-20@2x.svg" />
                    </div>
                    <div class="private fredoka-light-black-16px">Private</div>
                </div>
                <div class="trash fredoka-light-black-16px">trash</div>
                <!--<div class="group-15 border-0-4px-black">
                </div>-->
                <!--<ul>
                    <todo-item v-for="(todo) in todos"
                               :title="todo.title"
                               :key="todo.id"
                               @remove="todos.splice(index, 1)"></todo-item>
                </ul>-->

                <!--<div class="overlap-group3">
                    <div class="rectangle-14 border-0-4px-white"></div>
                    <div class="rectangle-15 border-0-4px-white" onclick=""></div>
                </div>-->
                <div class="overlap-group4">
                    <div class="rectangle-12"></div>
                    <div class="all-notes fredoka-light-black-16px">All notes</div>
                    <div class="overlap-group-1">
                        <div class="group-67">
                            <img class="vector-1"
                                 src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/vector-1-8@2x.svg" />
                            <img class="vector"
                                 src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/vector-2-8@2x.svg" />
                            <img class="vector"
                                 src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/vector-3-7@2x.svg" />
                        </div>
                        <img class="rectangle-36"
                             src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/rectangle-36-7@2x.svg" />
                    </div>
                </div>
                <div class="overlap-group5">
                    <img class="group-71"
                         src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/group-71@2x.svg" />
                    <div class="ellipse-7 border-0-5px-white"></div>
                </div>
                <div class="overlap-group6">
                    <div class="workspace fredoka-light-black-16px">Workspace</div>
                    <img class="group-68"
                         src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/group-68-3@2x.svg" />
                </div>
            </div>
            <img class="mask-group-1"
                 src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/mask-group-19@2x.svg" />
            <div class="group-10">
                <div class="overlap-group-2">
                    <div class="rectangle-9 border-0-3px-fresh-air"></div>
                    <div class="text-1 fredoka-bold-white-30px">?</div>
                </div>
                <div class="group-12 border-0-3px-fresh-air">
                    <img class="icon-star"
                         src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/star-1-3@2x.svg" />
                </div>
                <div class="group-13 border-0-3px-fresh-air">
                    <img class="mask-group-2"
                         src="https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/mask-group-22@2x.svg" />
                </div>
                <div class="group-14 border-0-3px-fresh-air" onclick=""></div>
            </div>
        </div>
    </div>

    <li>
        {{ title }}
        <button id="logout-button" @click.prevent="handleLogout">Log out</button>
        <h3 v-if="!username">You are not logged in!</h3>
        <h3 v-if="username" id="backgr">Hi,{{username}} </h3>



        <h3><font color="blue"> {{ title }} </font></h3>
        <error v-if="error" :error="error" />
        <img :src="require('@/assets/createpage.jpg')" />

        <form v-on:submit.prevent="addNewTodo">
            <label for="new-todo">Add a todo</label>
            <input v-model="newTodoText"
                   placeholder="text" />
            <button>
                <!--<div class="overlap-group3">
                    <div class="rectangle-14 border-0-4px-white"></div>
                    <div class="rectangle-15 border-0-4px-white" ></div>
                </div>-->
                add
            </button>
        </form>
        <button class="btn btn-primary btn-block">Create First Page</button>
    </li>

</template>

<style scoped>
    #logout-button {
        background-color: rgb(166, 0, 255);
        color: white;
        border: none;
        padding: 5px 10px;
    }

    #backgr {
        text-align: center;
        background-color: aqua;
    }

    #logout-button[disabled] {
        background-color: lightgray;
        color: gray;
    }

    .desktop-11 {
        align-items: flex-start;
        background-color: var(--mystic);
        display: flex;
        height: 1024px;
        overflow: hidden;
        width: 1440px;
    }


        .desktop-11 .overlap-group7 {
            height: 1118px;
            margin-left: -88px;
            margin-top: -94.24px;
            position: relative;
            width: 1678px;
            z-index: 1;
        }

        .desktop-11 .ellipse-3 {
            background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
            border-radius: 179.63px;
            height: 359px;
            left: 37px;
            position: absolute;
            top: 37px;
            transform: rotate(-13.71deg);
            width: 359px;
        }

        .desktop-11 .ellipse-5 {
            background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
            border-radius: 143.16px;
            height: 286px;
            left: 1339px;
            position: absolute;
            top: 590px;
            transform: rotate(-120.00deg);
            width: 286px;
        }

        .desktop-11 .ellipse-6 {
            background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
            border-radius: 117.04px;
            height: 234px;
            left: 1252px;
            position: absolute;
            top: 721px;
            transform: rotate(-60.00deg);
            width: 234px;
        }

        .desktop-11 .ellipse-4 {
            height: 359px;
            left: 50px;
            position: absolute;
            top: 196px;
            width: 259px;
        }

        .desktop-11 .rectangle-24 {
            -webkit-backdrop-filter: blur(15px) brightness(100%);
            backdrop-filter: blur(15px) brightness(100%);
            background-color: var(--white-42);
            border-radius: 13px;
            height: 1024px;
            left: 108px;
            position: absolute;
            top: 94px;
            width: 1402px;
        }

        .desktop-11 .line-1 {
            height: 1px;
            left: 171px;
            position: absolute;
            top: 149px;
            width: 1316px;
        }

        .desktop-11 .line-2 {
            height: 968px;
            left: 396px;
            position: absolute;
            top: 150px;
            width: 1px;
        }

        .desktop-11 .group-18 {
            height: 82px;
            left: 270px;
            position: absolute;
            top: 175px;
            width: 82px;
        }

        .desktop-11 .title {
            left: 434px;
            letter-spacing: 0;
            position: absolute;
            top: 190px;
            width: 179px;
        }

        .desktop-11 .overlap-group1 {
            height: 32px;
            left: 226px;
            position: absolute;
            top: 362px;
            width: 125px;
        }

        .desktop-11 .rectangle-12 {
            background-color: var(--white-2);
            border-radius: 5px;
            height: 30px;
            left: 0;
            position: absolute;
            top: 0;
            width: 125px;
        }

        .desktop-11 .fix {
            left: 38px;
            letter-spacing: 0;
            position: absolute;
            top: 5px;
            width: 58px;
        }

        .desktop-11 .group-container {
            height: 31px;
            left: 0;
            position: absolute;
            top: 1px;
            width: 33px;
        }

        .desktop-11 .group-23 {
            height: 31px;
            left: 2px;
            position: absolute;
            top: 0;
            width: 31px;
        }

        .desktop-11 .group-24 {
            height: 31px;
            left: 0;
            position: absolute;
            top: 0;
            width: 31px;
        }

        .desktop-11 .overlap-group2 {
            align-items: center;
            background-color: var(--white-2);
            border-radius: 5px;
            display: flex;
            height: 30px;
            left: 226px;
            min-width: 125px;
            padding: 4.2px 4.7px;
            position: absolute;
            top: 396px;
        }

        .desktop-11 .group-container-1 {
            align-self: flex-end;
            height: 20px;
            position: relative;
            width: 27px;
        }

        .desktop-11 .overlap-group {
            height: 19px;
            left: 0;
            position: absolute;
            top: 0;
            width: 27px;
        }

        .desktop-11 .group-67 {
            align-items: flex-start;
            background-color: var(--portage);
            border-radius: 3px;
            display: flex;
            flex-direction: column;
            left: 3px;
            min-height: 18px;
            padding: 3.0px 3.3px;
            position: absolute;
            top: 0;
            width: 19px;
        }

        .desktop-11 .vector-1 {
            height: 1px;
            margin-left: 0;
            width: 12px;
        }

        .desktop-11 .vector {
            height: 1px;
            margin-left: 0;
            margin-top: 2px;
            width: 12px;
        }

        .desktop-11 .rectangle-36 {
            height: 15px;
            left: 0;
            position: absolute;
            top: 4px;
            width: 27px;
        }

        .desktop-11 .mask-group {
            height: 15px;
            left: 15px;
            position: absolute;
            top: 5px;
            width: 12px;
        }

        .desktop-11 .private {
            letter-spacing: 0;
            margin-left: 6px;
            margin-top: 1.12px;
            min-height: 19px;
            width: 62px;
        }

        .desktop-11 .trash {
            left: 261px;
            letter-spacing: 0;
            position: absolute;
            top: 793px;
            width: 41px;
        }

        .desktop-11 .group-15 {
            -webkit-backdrop-filter: blur(15px) brightness(100%);
            backdrop-filter: blur(15px) brightness(100%);
            background-color: var(--white-32);
            border-radius: 13px;
            height: 139px;
            /*            left: 428px;
                position: absolute;
                top: 259px;
    */ width: 197px;
        }

        .desktop-11 .overlap-group3 {
            height: 32px;
           /* left: 511px;
            position: absolute;
            top: 313px;*/
            width: 32px;
        }

        .desktop-11 .rectangle-14 {
            background: linear-gradient(180deg, rgb(92.84, 137.29, 227.37) 0%, rgb(146.62, 242.12, 255) 100%);
            border-radius: 10px;
            height: 32px;
            left: 13px;
            position: absolute;
            top: 0;
            transform: rotate(-90.00deg);
            width: 6px;
        }

        .desktop-11 .rectangle-15 {
            -webkit-backdrop-filter: blur(4px) brightness(100%);
            backdrop-filter: blur(4px) brightness(100%);
            background: linear-gradient(180deg, rgb(92.84, 137.29, 227.37) 0%, rgb(146.62, 242.12, 255) 100%);
            border-radius: 10px;
            height: 32px;
            left: 13px;
            position: absolute;
            top: 0;
            transform: rotate(-180deg);
            width: 6px;
        }

        .desktop-11 .overlap-group4 {
            height: 31px;
            left: 226px;
            position: absolute;
            top: 330px;
            width: 125px;
        }

        .desktop-11 .all-notes {
            left: 38px;
            letter-spacing: 0;
            position: absolute;
            top: 4px;
            width: 79px;
        }

        .desktop-11 .overlap-group-1 {
            height: 19px;
            left: 5px;
            position: absolute;
            top: 4px;
            width: 27px;
        }

        .desktop-11 .overlap-group5 {
            border-radius: 8.67px;
            height: 17px;
            left: 355px;
            position: absolute;
            top: 302px;
            width: 17px;
        }

        .desktop-11 .group-71 {
            height: 11px;
            left: 3px;
            position: absolute;
            top: 3px;
            width: 11px;
        }

        .desktop-11 .ellipse-7 {
            border-radius: 8.67px;
            height: 17px;
            left: 0;
            position: absolute;
            top: 0;
            width: 17px;
        }

        .desktop-11 .overlap-group6 {
            background-color: var(--white-2);
            border-radius: 5px;
            height: 30px;
            left: 226px;
            position: absolute;
            top: 296px;
            width: 125px;
        }

        .desktop-11 .workspace {
            left: 38px;
            letter-spacing: 0;
            position: absolute;
            top: 5px;
            width: 87px;
        }

        .desktop-11 .group-68 {
            height: 21px;
            left: 18px;
            position: absolute;
            top: 3px;
            width: 27px;
        }

        .desktop-11 .mask-group-1 {
            height: 29px;
            left: 140px;
            position: fixed;
            top: 694px;
            width: 29px;
            z-index: 2;
        }

        .desktop-11 .group-10 {
            align-items: center;
            box-shadow: 0px 2px 2px #5cffdd;
            display: flex;
            height: 31px;
            left: 1158px;
            min-width: 141px;
            padding: 0 0.0px;
            position: fixed;
            top: 14px;
            z-index: 3;
        }

        .desktop-11 .overlap-group-2 {
            align-self: flex-end;
            height: 31px;
            margin-bottom: 0;
            position: relative;
            width: 27px;
        }

        .desktop-11 .rectangle-9 {
            background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);
            border-radius: 13px;
            height: 27px;
            left: 0;
            position: absolute;
            top: 2px;
            width: 27px;
        }

        .desktop-11 .text-1 {
            -webkit-background-clip: text !important;
            -webkit-text-fill-color: transparent;
            background: linear-gradient(180deg, rgb(39.91, 92.81, 195.5) 0%, rgba(107.09, 43.24, 157.25, 0) 100%);
            background-clip: text;
            left: 7px;
            letter-spacing: 0;
            position: absolute;
            text-align: center;
            text-fill-color: transparent;
            top: 0;
            width: 13px;
        }

        .desktop-11 .group-12 {
            align-items: flex-start;
            background: linear-gradient(180deg, rgba(246, 246, 249, 0.27) 0%, rgb(255, 255, 255) 0.01%, rgb(232, 241, 253) 100%);
            border-radius: 13px;
            display: flex;
            height: 27px;
            margin-left: 11px;
            margin-top: 0;
            min-width: 27px;
            padding: 4.8px 4.4px;
        }

        .desktop-11 .icon-star {
            height: 17px;
            width: 18px;
        }

        .desktop-11 .group-13 {
            align-items: flex-start;
            background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);
            border-radius: 13px;
            display: flex;
            height: 27px;
            margin-left: 11px;
            margin-top: 0;
            min-width: 27px;
            padding: 5.4px 4.9px;
        }

        .desktop-11 .mask-group-2 {
            height: 16px;
            width: 17px;
        }

        .desktop-11 .group-14 {
            background: linear-gradient(180deg, rgba(248.63, 248.63, 248.63, 0) 0%, rgb(219.94, 236.07, 255) 100%);
            background-image: url(https://anima-uploads.s3.amazonaws.com/projects/62d2d7d3f9ede3e68a5f3c76/releases/62d2d824588fd82329642652/img/mask-group-21@2x.svg);
            background-size: 100% 100%;
            border-radius: 13px;
            height: 27px;
            margin-bottom: 0.6px;
            margin-left: 11px;
            width: 27px;
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

    .listeners-active,
    .listeners-active * {
        pointer-events: auto;
    }

    .hidden,
    .hidden * {
        pointer-events: none;
        visibility: hidden;
    }

    .listeners-active-click,
    .listeners-active-click * {
        cursor: pointer;
    }

    * {
        box-sizing: border-box;
    }

    :root {
        --anakiwa: #85f0ff80;
        --black: #000000;
        --fresh-air: #aed8ff73;
        --mystic: #e3e8ee;
        --portage: #799fec;
        --white: #ffffff;
        --white-2: #ffffff03;
        --white-32: #ffffff3b;
        --white-42: #ffffffb2;
        --font-size-m: 16px;
        --font-size-xl2: 25px;
        --font-size-xxl: 30px;
        --font-family-fredoka: "Fredoka", Helvetica;
    }

    .fredoka-light-black-16px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-m);
        font-style: normal;
        font-weight: 300;
    }

    .fredoka-medium-black-25px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xl2);
        font-style: normal;
        font-weight: 500;
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

    .border-0-4px-white {
        border: 0.4px solid var(--white);
    }

    .border-2px-white {
        border: 2px solid var(--white);
    }

    .border-0-4px-black {
        border: 0.4px solid var(--black);
    }

    .border-0-5px-white {
        border: 0.5px solid var(--white);
    }
</style>



<script>
    import TodoItem from './TodoItem'
    //import Userpage from './Userpage'
    import axios from 'axios'

    export default {

        name: 'SP',

        components: { TodoItem },

        data() {
            //const response =  axios.get('api/Stick/GetAll', {
            //    headers: {
            //        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
            //    }
            //});
            return {
                list: [],

                newTodoText: '',
                todos: [
                    {
                        id: 1,
                        title: 'Userpage1'
                    },
                    {
                        id: 2,
                        title: 'Userpage2'
                    },
                    {
                        id: 3,
                        title: 'Userpage3'
                    }
                ],
                nextTodoId: 4
            }
        },
        methods: {
            addNewTodo() {
                this.todos.push({
                    id: this.nextTodoId++,
                    title: this.newTodoText
                })
                this.newTodoText = '';
                this.addNew();
            },
             addNew() {
                const response = axios.get('api/Stick/GetAll', {
                    headers: {
                        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                    }
                });
               //  this.todos = response;
                 this.list = response;
            }
        }
    }
</script>


<!--<template>
    <form v-on:submit.prevent="addNewTodo">
        <label for="new-todo">Add a todo</label>
        <input v-model="newTodoText"
               id="new-todo"
               placeholder="E.g. Feed the cat" />
        <button>Add</button>
    </form>
    <ul>
        <todo-item v-for="(todo) in todos"
                   :title="todo.title"
                   :key="todo.id"
                   @remove="todos.splice(index, 1)"></todo-item>
    </ul>
</template>-->
