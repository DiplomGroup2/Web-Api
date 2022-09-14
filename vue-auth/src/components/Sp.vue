<template>
    <input type="hidden" id="anPageName" name="page" value="desktop-21" />
    <div class="container-center-horizontal">
        <div class="desktop-21 screen">
            <div class="overlap-group9">
                <div class="ellipse-3"></div>
                <div class="ellipse-5"></div>
                <div class="ellipse-6"></div>
                <img class="ellipse-4"
                     src="../assets/ellipse-4-1@2x.svg" />

                <div class="rectangle-24 border-2px-white">
                    <div class=" border-2px-white" style="margin-top: 150px; margin-left: 330px; min-height:870px; ">
                        <div class="group-129 border-0-4px-black">
                            <div class="component-2">
                                <div class="overlap-group8" v-on:click="addNewTodo">
                                    <div class="rectangle-14 border-0-4px-white"></div>
                                    <div class="rectangle-15 border-0-4px-white"></div>
                                </div>

                            </div>
                        </div>
                        <todo-item v-for="(todo) in todos"
                                   :title="todo.name"
                                   :key="todo.id"
                                   :records="todo.records"
                                   :createdPage="todo.createdPage"
                                   :pageId="todo.id"
                                   :group="todo.group"
                                   :alltags="alltags"
                                   @remove="DeleteTodo(todo)"
                                   @refresh="getAllPages()"
                                   @refreshTags="get_all_tags()">
                        </todo-item>

                    </div>
                </div>



                <div class="rectangle-30"></div>
                <img class="line-1"
                     src="../assets/line-1@1x.svg" />
                <img class="line-2"
                     src="../assets/line-2@1x.svg" />
                <img class="group-18"
                     src="../assets/group-18@2x.svg" />
                <h1 class="title fredoka-medium-black-25px">Personal pages</h1>

                <div class="trash fredoka-light-black-16px" id="outtooltip">
                    <img class="mask-group-3" src="../assets/mask-group-1@2x.svg" />
                    <span id="tooltiptext2">Trash</span>
                    <!-- Trash-->
                </div>

                <div class="overlap-group3">
                    <!--<div class="rectangle-121"></div>-->
                    <div class="overlap-group2" v-on:click="getAllPages">
                        <div class="group-container">

                            <div class="overlap-group-1">
                                <div class="group-67">
                                    <img class="vector-1"
                                         src="../assets/vector-1-2@2x.svg" />
                                    <img class="vector"
                                         src="../assets/vector-2-2@2x.svg" />
                                    <img class="vector"
                                         src="../assets/vector-3-1@2x.svg" />
                                </div>
                                <img class="rectangle-36"
                                     src="../assets/rectangle-36-1@2x.svg" />
                            </div>
                        </div>
                        <div class="all-notes fredoka-light-black-16px">All notes</div>
                    </div>

                    <div class="overlap-group2" v-on:click="getPageLast(10)">
                        <div class="group-container">

                            <div class="overlap-group-1">
                                <div class="group-67">
                                    <img class="vector-1"
                                         src="../assets/vector-1-2@2x.svg" />
                                    <img class="vector"
                                         src="../assets/vector-2-2@2x.svg" />
                                    <img class="vector"
                                         src="../assets/vector-3-1@2x.svg" />
                                </div>
                                <img class="rectangle-36"
                                     src="../assets/rectangle-36-1@2x.svg" />
                            </div>
                        </div>
                        <div class="all-notes fredoka-light-black-16px">Last 10</div>
                    </div>

                    <div class="overlap-group2" v-on:click="getUntagged()">
                        <div class="group-container">

                            <div class="overlap-group-1">
                                <div class="group-67">
                                    <img class="vector-1"
                                         src="../assets/vector-1-2@2x.svg" />
                                    <img class="vector"
                                         src="../assets/vector-2-2@2x.svg" />
                                    <img class="vector"
                                         src="../assets/vector-3-1@2x.svg" />
                                </div>
                                <img class="rectangle-36"
                                     src="../assets/rectangle-36-1@2x.svg" />
                            </div>
                        </div>
                        <div class="all-notes fredoka-light-black-16px">Untagged</div>
                    </div>

                    <div class="overlap-group2" v-for="item in alltags" :value="item.tag" :key="item.tag" v-on:click="getPagesTag(item.tag)">
                        <div class="group-container">
                            <div class="overlap-group">
                                <div class="group-67">
                                    <img class="vector-1"
                                         src="../assets/vector-1-1@2x.svg" />
                                    <img class="vector"
                                         src="../assets/vector-2-1@2x.svg" />
                                    <img class="vector"
                                         src="../assets/vector-3@2x.svg" />
                                </div>
                                <img class="rectangle-36"
                                     src="../assets/rectangle-36@2x.svg" />
                            </div>
                            <img class="mask-group"
                                 src="../assets/mask-group-2@2x.svg" />
                        </div>
                        <div class="private fredoka-light-black-16px">
                            {{item.tag}}
                        </div>
                    </div>
                </div>
                <div class="overlap-group4">
                    <img class="group-71" src="../assets/group-71@2x.svg" />
                    <div class="ellipse-7 border-0-5px-white"></div>
                </div>
                <div class="overlap-group5">
                    <img class="group-68" src="../assets/group-68@2x.svg" />
                    <div class="workspace fredoka-light-black-16px">Workspace</div>
                </div>
                <!--<div class="rectangle-126 border-0-4px-glacier"></div>-->
                <!--<select v-model="select" class="rectangle-126 border-0-4px-glacier">
                    <option value="" disabled hidden>Choose a tag</option>
                    <option>movies</option>
                    <option>sport</option>
                    <option>travelling</option>
                    <option>education</option>
                    <option>politics</option>
                    <option>economics</option>
                </select>-->
                <!--<div class="group-136">
                    <div class="overlap-group6">
                        <div class="ellipse-43 border-1px-glacier"></div>
                        <img class="line-9" src="../assets/line-9@2x.svg" />
                    </div>
                </div>-->
            </div>
            <img class="mask-group-3" src="../assets/mask-group-1@2x.svg" />

            <!--<div class="tags fredoka-light-gray-12px">#tags</div>-->
            <div class="group-10">
                <div class="overlap-group-3">
                    <div class="rectangle-9 border-0-3px-fresh-air"></div>
                    <div class="text-1 fredoka-bold-white-30px" @click="QuestionPage">?</div>
                </div>
                <div class="group-12 border-0-3px-fresh-air">
                    <img class="icon-star" src="../assets/star-1@2x.svg" />
                </div>

                <div class="group-13 border-0-3px-fresh-air">
                    <img class="mask-group-4" src="../assets/mask-group-6@2x.svg" />
                </div>
                <!--ПОДКЛЮЧЕНИЕ ПОДСКАЗКИ TOOLTIP LOGOUT -->
                <div class="group-14 border-0-3px-fresh-air" id="outtooltip">
                    <!--<span id="tooltiptext">Log out</span>-->
                    <span id="tooltiptext">
                        <input type="hidden" id="anPageName" name="page" value="component-22" />
                        <!--<div class="container-center-horizontal">-->
                        <div class="component-22 screen">
                            <div class="component-22-1">
                                <div class="flex-col">
                                    <div class="flex-row">
                                        <div class="profile">Profile</div>
                                        <!--<div class="overlap-group401">
                                          <div class="group-11601">
                                            <img
                                              class="rectangle-11801"
                                              src="https://anima-uploads.s3.amazonaws.com/projects/630cefa5a839203234c33557/releases/630cefe0260e835b228e4406/img/rectangle-118@2x.svg"
                                            />
                                          </div>
                                          <div class="ellipse-40101"></div>
                                        </div>-->
                                    </div>
                                    <img class="line-601"
                                         src="../assets/line-6-9@2x.svg" />
                                </div>
                                <div class="flex-row-101">
                                    <div class="overlap-group101">
                                        <div class="rectangle-601"></div>
                                        <img class="icon-user101"
                                             src="../assets/mask-group-56@2x.svg" />
                                    </div>
                                    <div class="flex-col-101">
                                        <div class="username fredoka-light-black-16px">



                                            <h3 v-if="!username" id="backgr">Username/</h3>
                                            <h3 v-if="username" id="backgr">{{username}} </h3>



                                        </div>
                                        <div class="free">Free</div>
                                    </div>
                                    <!-- <div class="overlap-group101"><div class="upgrade">Upgrade</div></div>-->
                                </div>
                                <img class="line-701"
                                     src="../assets/line-7@2x.svg" />
                                <div class="overlap-group201">
                                    <img class="mask-group101"
                                         src="../assets/mask-group-57@2x.svg" />
                                    <div class="account-settings fredoka-light-granite-gray-16px">Account settings</div>
                                </div>
                                <img class="line-801"
                                     src="../assets/line-8@2x.svg" />
                                <div class="overlap-group301">
                                    <img class="mask-group-101"
                                         src="../assets/mask-group-58@2x.svg" />
                                    <div class="sing-out fredoka-light-granite-gray-16px" @click="handleLogout">Sign Out</div>
                                </div>
                            </div>
                            <!--</div>-->
                        </div>

                    </span>
                </div>

            </div>
        </div>
    </div>
</template>

<style scoped>
    /* screen - component-22 */

    .component-22 {
        align-items: flex-start;
        display: flex;
        height: 1024px;
        width: 1440px;
    }

        .component-22 .component-22-1 {
            -webkit-backdrop-filter: blur(8px) brightness(100%);
            align-items: center;
            backdrop-filter: blur(8px) brightness(100%);
            background-color: #ffffffeb;
            border: 0.4px solid;
            border-color: #cacaca;
            border-radius: 13px;
            box-shadow: 0px 4px 4px #00000040;
            display: flex;
            flex-direction: column;
            min-height: 260px;
            padding: 21.2px 14.3px;
            width: 260px;
            margin-right: 50px;
        }

        .component-22 .flex-col {
            display: flex;
            flex-direction: column;
            margin-right: 0;
            min-height: 38px;
            /*width: 292px;*/
            width: 200px;
        }

        .component-22 .flex-row {
            align-items: flex-start;
            display: flex;
            margin-left: 0;
            width: 200px;
            /*min-width: 271px;*/
        }


        .component-22 .profile {
            color: var(--black);
            font-family: var(--font-family-fredoka);
            font-size: var(--font-size-m);
            font-weight: 400;
            letter-spacing: 0;
            min-height: 18px;
            width: 49px;
            margin-left: 18px;
        }

        .component-22 .overlap-group401 {
            align-self: flex-end;
            border-radius: 15px;
            height: 20px;
            margin-left: 181px;
            position: relative;
            width: 41px;
        }

        .component-22 .group-11601 {
            align-items: flex-end;
            background-color: var(--alto);
            border-radius: 15px;
            display: flex;
            height: 20px;
            left: 0;
            min-width: 41px;
            padding: 1.4px 1.4px;
            position: absolute;
            top: 0;
        }

        .component-22 .rectangle-11801 {
            height: 17px;
            width: 38px;
        }

        .component-22 .ellipse-40101 {
            background-color: #f7f7f7;
            border: 1px solid;
            border-color: var(--white);
            border-radius: 8.62px;
            cursor: pointer;
            height: 17px;
            left: 1px;
            position: absolute;
            top: 1px;
            width: 17px;
        }

        .component-22 .line-601 {
            height: 1px;
            margin-top: 17px;
            width: 292px;
        }

        .component-22 .flex-row-101 {
            align-items: center;
            display: flex;
            margin-left: 0;
            margin-top: 15px;
            min-width: 271px;
        }

        .component-22 .overlap-group101 {
            height: 50px;
            position: relative;
            width: 50px;
        }

        .component-22 .rectangle-601 {
            background-color: #ebebeb;
            border: 0.46px solid;
            border-color: var(--white);
            border-radius: 20.13px;
            height: 60px;
            left: -40px;
            position: absolute;
            top: -20px;
            width: 122px;
        }

        .component-22 .icon-user101 {
            height: 50px;
            left: -35px;
            position: absolute;
            top: -20px;
            width: 50px;
        }

        .component-22 .flex-col-101 {
            align-items: flex-start;
            display: flex;
            flex-direction: column;
            margin-bottom: 2.0px;
            margin-left: 15px;
            min-height: 39px;
            width: 75px;
        }

        .component-22 .username {
            letter-spacing: 0;
            min-height: 18px;
            width: 75px;
        }

        .component-22 .free {
            color: #00000066;
            font-family: var(--font-family-fredoka);
            font-size: var(--font-size-xs);
            font-weight: 300;
            letter-spacing: 0;
            margin-top: 4px;
            min-height: 18px;
            width: 26px;
        }

        .component-22 .overlap-group101 {
            align-items: flex-start;
            background-color: var(--white);
            border: 0.4px solid;
            border-color: var(--black);
            border-radius: 8px;
            display: flex;
            height: 26px;
            margin-left: 49px;
            margin-top: 0;
            min-width: 81px;
            padding: 3.5px 14.6px;
        }

        .component-22 .upgrade {
            color: var(--black);
            font-family: var(--font-family-fredoka);
            font-size: var(--font-size-s);
            font-weight: 400;
            letter-spacing: 0;
            min-height: 16px;
            width: 51px;
        }

        .component-22 .line-701 {
            align-self: flex-start;
            height: 1px;
            margin-top: 15px;
            width: 292px;
        }

        .component-22 .overlap-group201 {
            align-items: flex-start;
            background-color: var(--coconut);
            border-radius: 4px;
            display: flex;
            height: 42px;
            margin-left: 0;
            margin-top: 15px;
            min-width: 271px;
            padding: 10.7px 9.7px;
        }

        .component-22 .mask-group101 {
            height: 21px;
            margin-top: 0;
            width: 21px;
        }

        .component-22 .account-settings {
            letter-spacing: 0;
            margin-left: 7px;
            min-height: 18px;
            width: 118px;
            color: gray;
        }

        .component-22 .line-801 {
            align-self: flex-start;
            height: 1px;
            margin-top: 17px;
            width: 292px;
        }

        .component-22 .overlap-group301 {
            align-items: flex-start;
            background-color: var(--coconut);
            border-radius: 4px;
            display: flex;
            height: 42px;
            margin-left: 0;
            margin-top: 18px;
            min-width: 271px;
            padding: 10.6px 11.7px;
        }

        .component-22 .mask-group-101 {
            align-self: center;
            height: 19px;
            margin-bottom: 0.35px;
            width: 19px;
        }

        .component-22 .sing-out {
            letter-spacing: 0;
            margin-left: 7px;
            min-height: 18px;
            width: 64px;
            color: gray;
            cursor: pointer;
        }

    :root {
        --alto: #d9d9d9;
        --black: #000000;
        --coconut: #fefefe;
        --granite-gray: #666666a6;
        --white: #ffffff;
        --font-size-m: 16px;
        --font-size-s: 13px;
        --font-size-xs: 12px;
        --font-family-fredoka: "Fredoka", Helvetica;
    }

    .fredoka-light-granite-gray-16px {
        color: var(--granite-gray);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-m);
        font-style: normal;
        font-weight: 300;
    }

    .fredoka-light-black-16px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-m);
        font-style: normal;
        font-weight: 300;
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







    /*старый код*/
    #outtooltip {
        position: relative;
        display: inline-block;
    }

        #outtooltip #tooltiptext {
            visibility: hidden;
            width: 120px;
            color: #fff;
            text-align: center;
            border-radius: 6px;
            border-color: black;
            padding: 20px 0;
            /* Position the tooltip */
            position: absolute;
            z-index: 1;
        }

        #outtooltip #tooltiptext2 {
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

        #outtooltip:hover #tooltiptext2 {
            visibility: visible;
            cursor: pointer;
        }

    .desktop-21 {
        align-items: flex-start;
        /*background-color: var(--mystic);*/
        background-color: #e3e8ee;
        display: flex;
        min-height: 1124px;
        /*overflow: hidden;*/
        /*width: 1440px;*/
        /*width: 1519px;*/
    }

        .desktop-21 .overlap-group9 {
            /*height: 1118px;*/
            margin-left: -88px;
            margin-top: -94.24px;
            position: relative;
            width: 1678px;
            z-index: 1;
        }

        .desktop-21 .ellipse-3 {
            background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
            border-radius: 179.63px;
            height: 359px;
            left: 37px;
            position: absolute;
            top: 37px;
            transform: rotate(13.71deg);
            width: 359px;
        }

        .desktop-21 .ellipse-5 {
            background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
            border-radius: 143.16px;
            height: 286px;
            left: 1339px;
            position: absolute;
            top: 590px;
            transform: rotate(-120.00deg);
            width: 286px;
        }

        .desktop-21 .ellipse-6 {
            background: linear-gradient(180deg, rgb(159.98, 130.33, 244.38) 0%, rgba(100.06, 176.76, 247.56, 0.55) 50.76%, rgba(250.96, 53.12, 255, 0) 100%);
            border-radius: 117.04px;
            height: 234px;
            left: 1252px;
            position: absolute;
            top: 721px;
            transform: rotate(-60.00deg);
            width: 234px;
        }

        .desktop-21 .ellipse-4 {
            height: 359px;
            left: 88px;
            position: absolute;
            top: 196px;
            width: 259px;
        }
        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
        .desktop-21 .rectangle-24 {
            -webkit-backdrop-filter: blur(15px) brightness(100%);
            backdrop-filter: blur(15px) brightness(100%);
            background-color: var(--white-42);
            border-radius: 13px;
            min-height: 1024px;
            left: 140px;
            position: absolute;
            top: 94px;
            width: 1402px;
        }

        .desktop-21 .rectangle-30 {
            background-color: var(--black-2);
            border: 1px solid transparent;
            border-image: linear-gradient(to bottom, rgb(255, 255, 255) 71.35%, rgba(255, 255, 255, 0) 98.44%) 1;
            border-radius: 10px 0px 0px 10px;
            height: 31px;
            left: 219px;
            position: absolute;
            top: 328px;
            width: 176px;
        }

        .desktop-21 .line-1 {
            height: 1px;
            left: 171px;
            position: absolute;
            top: 149px;
            width: 1316px;
        }

        .desktop-21 .line-2 {
            height: 968px;
            left: 396px;
            position: absolute;
            top: 150px;
            width: 1px;
        }

        .desktop-21 .group-18 {
            height: 82px;
            left: 270px;
            position: absolute;
            top: 175px;
            width: 82px;
        }

        .desktop-21 .title {
            left: 434px;
            letter-spacing: 0;
            position: absolute;
            top: 190px;
            width: 106px;
        }

        .desktop-21 .overlap-group2 {
            align-items: center;
            background-color: var(--white-2);
            border-radius: 5px;
            display: flex;
            height: 30px;
            /* left: 226px;*/
            min-width: 125px;
            padding: 3.9px 4.7px;
            /* position: absolute;
            top: 365px;*/
            cursor: pointer;
        }

        .desktop-21 .group-container {
            align-self: flex-end;
            height: 20px;
            position: relative;
            width: 27px;
        }

        .desktop-21 .overlap-group {
            height: 20px;
            left: 0;
            position: absolute;
            top: 0;
            width: 27px;
        }

        .desktop-21 .group-67 {
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

        .desktop-21 .vector-1 {
            height: 1px;
            margin-left: 0;
            width: 12px;
        }

        .desktop-21 .vector {
            height: 1px;
            margin-left: 0;
            margin-top: 2px;
            width: 12px;
        }

        .desktop-21 .rectangle-36 {
            height: 15px;
            left: 0;
            position: absolute;
            top: 5px;
            width: 27px;
        }

        .desktop-21 .mask-group {
            height: 15px;
            left: 15px;
            position: absolute;
            top: 5px;
            width: 12px;
        }

        .desktop-21 .private {
            letter-spacing: 0;
            margin-left: 6px;
            margin-top: 1.12px;
            min-height: 19px;
            width: 62px;
        }

        .desktop-21 .trash {
            left: 261px;
            letter-spacing: 0;
            position: absolute;
            top: 793px;
            width: 41px;
        }

        .desktop-21 .group-129 {
            -webkit-backdrop-filter: blur(15px) brightness(100%);
            backdrop-filter: blur(15px) brightness(100%);
            background-color: var(--white-32);
            border-radius: 13px;
            height: 191px;
            /*left: 725px;
    position: absolute;
    top: 259px;*/
            width: 264px;
            margin: 20px;
            display: inline-block;
        }

        .desktop-21 .overlap-group3 {
            height: 31px;
            left: 226px;
            position: absolute;
            top: 330px;
            width: 125px;
        }

        .desktop-21 .rectangle-121 {
            background-color: var(--white-2);
            border-radius: 5px;
            height: 30px;
            left: 0;
            position: absolute;
            top: 0;
            width: 125px;
        }

        .desktop-21 .all-notes {
            /* left: 38px;*/
            letter-spacing: 0;
            /* position: absolute;
            top: 4px;*/
            width: 79px;
        }

        .desktop-21 .overlap-group-1 {
            /* height: 20px;
            left: 5px;
            position: absolute;
            top: 4px;*/
            width: 27px;
        }

        .desktop-21 .overlap-group4 {
            border-radius: 8.67px;
            height: 17px;
            left: 355px;
            position: absolute;
            top: 302px;
            width: 17px;
        }

        .desktop-21 .group-71 {
            height: 11px;
            left: 3px;
            position: absolute;
            top: 3px;
            width: 11px;
        }

        .desktop-21 .ellipse-7 {
            border-radius: 8.67px;
            height: 17px;
            left: 0;
            position: absolute;
            top: 0;
            width: 17px;
        }

        .desktop-21 .overlap-group5 {
            align-items: flex-start;
            background-color: var(--white-2);
            border-radius: 5px;
            display: flex;
            height: 30px;
            justify-content: flex-end;
            left: 226px;
            min-width: 125px;
            padding: 2.8px 0;
            position: absolute;
            top: 296px;
        }

        .desktop-21 .group-68 {
            height: 21px;
            width: 27px;
        }

        .desktop-21 .workspace {
            align-self: center;
            letter-spacing: 0;
            margin-bottom: 1.07px;
            margin-left: 6px;
            min-height: 19px;
            width: 87px;
        }

        .desktop-21 .rectangle-126 {
            background-color: var(--white);
            border-radius: 13px;
            height: 31px;
            left: 991px;
            position: absolute;
            top: 107px;
            width: 198px;
        }

        .desktop-21 .group-136 {
            align-items: flex-start;
            background-color: var(--white);
            display: flex;
            height: 19px;
            justify-content: flex-end;
            left: 1158px;
            min-width: 21px;
            padding: 2.0px 2.7px;
            position: absolute;
            top: 113px;
        }

        .desktop-21 .overlap-group6 {
            height: 15px;
            position: relative;
            width: 15px;
        }

        .desktop-21 .ellipse-43 {
            border-radius: 5.73px/5.59px;
            height: 11px;
            left: 0;
            position: absolute;
            top: 0;
            width: 11px;
        }

        .desktop-21 .line-9 {
            height: 6px;
            left: 9px;
            position: absolute;
            top: 9px;
            width: 6px;
        }

        .desktop-21 .view {
            align-items: flex-start;
            display: flex;
            height: 192px;
            left: 428px;
            overflow: hidden;
            padding: 0.6px 0;
            top: 258px;
            width: 265px;
            position: absolute;
            display: inline-block;
        }

        .desktop-21 .overlap-group7 {
            -webkit-backdrop-filter: blur(15px) brightness(100%);
            align-items: flex-start;
            backdrop-filter: blur(15px) brightness(100%);
            background-color: var(--white);
            border-radius: 13px;
            box-shadow: 0px 4px 0px #8aa7de;
            display: flex;
            flex-direction: column;
            min-height: 187px;
            padding: 14.0px 19.7px;
            width: 265px;
        }

        .desktop-21 .flex-row {
            align-items: flex-start;
            align-self: center;
            display: flex;
            height: 21px;
            margin-left: 0.08px;
            min-width: 225px;
        }

        .desktop-21 .untitled {
            letter-spacing: 0;
            min-height: 20px;
            width: 68px;
        }

        .desktop-21 .overlap-group3-1 {
            align-items: flex-start;
            align-self: flex-end;
            background-color: var(--white);
            border-radius: 13px;
            display: flex;
            height: 19px;
            justify-content: flex-end;
            margin-left: 21px;
            min-width: 102px;
            padding: 3.7px 4.0px;
        }

        .desktop-21 .group-134 {
            align-items: flex-end;
            background-color: var(--white);
            display: flex;
            height: 11px;
            min-width: 15px;
            padding: 3.2px 2.7px;
        }

        .desktop-21 .vector-9 {
            height: 3px;
            width: 9px;
        }

        .desktop-21 .mask-group-1 {
            align-self: center;
            height: 18px;
            margin-left: 17px;
            margin-top: 0.89px;
            width: 18px;
        }

        .desktop-21 .flex-row-1 {
            align-items: flex-end;
            display: flex;
            height: 16px;
            margin-left: 0.4px;
            margin-top: 1px;
            min-width: 98px;
        }

        .desktop-21 .date {
            color: var(--gray);
            font-family: var(--font-family-fredoka);
            font-size: var(--font-size-xs);
            font-weight: 300;
            letter-spacing: 0;
            min-height: 14px;
            width: 40px;
        }

        .desktop-21 .vector-8 {
            height: 14px;
            margin-bottom: 0.14px;
            margin-left: 8px;
            width: 1px;
        }

        .desktop-21 .movies {
            align-self: flex-start;
            letter-spacing: 0;
            margin-left: 4px;
            min-height: 16px;
            width: 49px;
        }

        .desktop-21 .text {
            letter-spacing: 0;
            margin-top: 8px;
            min-height: 16px;
            width: 39px;
        }

        .desktop-21 .group-container-1 {
            align-items: flex-start;
            display: flex;
            margin-left: 0.88px;
            margin-top: 74px;
            min-width: 88px;
        }

        .desktop-21 .mask-group-2 {
            height: 21px;
            width: 21px;
        }

        .desktop-21 .group-133 {
            align-items: flex-start;
            align-self: flex-end;
            display: flex;
            margin-bottom: 0;
            margin-left: 13px;
            min-width: 22px;
            opacity: 0.5;
        }

        .desktop-21 .overlap-group1 {
            height: 20px;
            position: relative;
            width: 22px;
        }

        .desktop-21 .overlap-group-2 {
            height: 20px;
            left: 0;
            position: absolute;
            top: 0;
            width: 22px;
        }

        .desktop-21 .rectangle-39 {
            border-radius: 3.98px;
            height: 15px;
            left: 0;
            position: absolute;
            top: 0;
            width: 15px;
        }

        .desktop-21 .rectangle-37 {
            background-color: var(--white);
            border-radius: 5.31px;
            height: 17px;
            left: 5px;
            position: absolute;
            top: 3px;
            width: 17px;
        }

        .desktop-21 .line-5 {
            height: 9px;
            left: 13px;
            position: absolute;
            top: 7px;
            width: 1px;
        }

        .desktop-21 .line-6 {
            height: 1px;
            left: 9px;
            position: absolute;
            top: 11px;
            width: 9px;
        }

        .desktop-21 .group-132 {
            align-items: flex-end;
            display: flex;
            height: 20px;
            margin-left: 13px;
            min-width: 20px;
            opacity: 0.5;
            padding: 0.0px 0.0px;
        }

        .desktop-21 .overlap-group2-1 {
            height: 18px;
            position: relative;
            width: 20px;
        }

        .desktop-21 .arrow-1 {
            height: 14px;
            left: 5px;
            position: absolute;
            top: 0;
            width: 10px;
        }

        .desktop-21 .ellipse-42 {
            height: 10px;
            left: 0;
            position: absolute;
            top: 8px;
            width: 20px;
        }

        .desktop-21 .component-2 {
            align-items: flex-start;
            cursor: pointer;
            display: flex;
            height: 33px;
            left: 115px;
            min-width: 33px;
            position: absolute;
            top: 79px;
        }

        .desktop-21 .overlap-group8 {
            height: 33px;
            position: relative;
            width: 33px;
        }

        .desktop-21 .rectangle-14 {
            background: linear-gradient(180deg, rgb(92.84, 137.29, 227.37) 0%, rgb(146.62, 242.12, 255) 100%);
            border-radius: 10px;
            height: 33px;
            left: 13px;
            position: absolute;
            top: 0;
            transform: rotate(-90.00deg);
            width: 6px;
        }

        .desktop-21 .rectangle-15 {
            -webkit-backdrop-filter: blur(4px) brightness(100%);
            backdrop-filter: blur(4px) brightness(100%);
            background: linear-gradient(180deg, rgb(92.84, 137.29, 227.37) 0%, rgb(146.62, 242.12, 255) 100%);
            border-radius: 10px;
            height: 33px;
            left: 13px;
            position: absolute;
            top: 0;
            transform: rotate(180.00deg);
            width: 6px;
        }

        .desktop-21 .mask-group-3 {
            height: 29px;
            left: 140px;
            /*position: fixed;*/
            cursor: pointer;
            top: 694px;
            width: 29px;
            z-index: 2;
        }

        .desktop-21 .tags {
            left: 915px;
            letter-spacing: 0;
            position: fixed;
            top: 19px;
            width: 40px;
            z-index: 4;
        }

        .desktop-21 .group-10 {
            align-items: center;
            /*box-shadow: 0px 2px 2px #5cffdd;*/
            display: flex;
            height: 34px;
            left: 1133px;
            min-width: 165px;
            position: fixed;
            top: 10px;
            z-index: 3;
        }

        .desktop-21 .overlap-group-3 {
            align-self: flex-end;
            height: 34px;
            margin-bottom: 0;
            position: relative;
            width: 27px;
        }

        .desktop-21 .rectangle-9 {
            /*background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);*/
            border-radius: 13px;
            height: 27px;
            left: 0;
            position: absolute;
            top: 5px;
            width: 27px;
        }

        .desktop-21 .text-1 {
            -webkit-background-clip: text !important;
            -webkit-text-fill-color: transparent;
            background: linear-gradient( 180deg, rgb(39.91, 92.81, 195.5) 0%, rgba(107.09, 43.24, 157.25, 0) 100% );
            background-clip: text;
            color: transparent;
            font-family: var(--font-family-fredoka);
            font-size: 23px;
            font-weight: 700;
            left: 7px;
            letter-spacing: 0;
            position: absolute;
            text-align: center;
            text-fill-color: transparent;
            top: 0;
            width: 13px;
            cursor: pointer;
        }

        .desktop-21 .group-12 {
            align-items: flex-start;
            /*background: linear-gradient(180deg, rgba(246, 246, 249, 0.27) 0%, rgb(255, 255, 255) 0.01%, rgb(232, 241, 253) 100%);*/
            border-radius: 13px;
            display: flex;
            height: 27px;
            margin-left: 19px;
            margin-top: 3.18px;
            min-width: 27px;
            padding: 3.9px 4.4px;
        }

        .desktop-21 .icon-star {
            height: 17px;
            width: 18px;
        }

        .desktop-21 .group-13 {
            align-items: flex-start;
            /*background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);*/
            border-radius: 13px;
            display: flex;
            height: 27px;
            margin-left: 19px;
            margin-top: 3.18px;
            min-width: 27px;
            padding: 5.4px 4.9px;
        }

        .desktop-21 .mask-group-4 {
            height: 16px;
            width: 17px;
        }

        .desktop-21 .group-14 {
            background: linear-gradient(180deg, rgb(253, 254, 255) 0%, rgb(234, 242, 253) 100%);
            background-image: url("../assets/mask-group-5@2x.svg");
            background-size: 100% 100%;
            border-radius: 13px;
            height: 27px;
            margin-left: 19px;
            margin-top: 2.58px;
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

    * {
        box-sizing: border-box;
    }

    :root {
        --anakiwa: #85f0ff80;
        --black: #000000;
        --black-2: #00000047;
        --black-3: #00000091;
        --black-4: #000000cc;
        --fresh-air: #aed8ff73;
        --glacier: #83b3de;
        --gray: #919192;
        --mystic: #e3e8ee;
        --portage: #799fec;
        --white: #ffffff;
        --white-2: #ffffff03;
        --white-32: #ffffff3b;
        --white-42: #ffffffb2;
        --font-size-l: 17px;
        --font-size-m: 16px;
        --font-size-s: 15px;
        --font-size-xs: 12px;
        --font-size-xxl2: 25px;
        --font-size-xxs: 10.4px;
        --font-size-xxxl2: 30px;
        --font-family-fredoka: "Fredoka", Helvetica;
    }

    .fredoka-light-black-16px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-m);
        font-style: normal;
        font-weight: 300;
    }

    .fredoka-light-gray-12px {
        color: var(--gray);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xs);
        font-style: normal;
        font-weight: 300;
    }

    #movies {
        margin-top: 2px;
    }

    .fredoka-medium-black-25px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xxl2);
        font-style: normal;
        font-weight: 500;
        white-space: nowrap;
    }

    .fredoka-light-white-16px {
        color: var(--white);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-m);
        font-style: normal;
        font-weight: 300;
    }

    .fredoka-medium-black-17px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-l);
        font-style: normal;
        font-weight: 500;
    }

    .fredoka-light-black-15px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-s);
        font-style: normal;
        font-weight: 300;
    }

    .fredoka-bold-white-30px {
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xxxl2);
        font-style: normal;
        font-weight: 700;
        margin-top: 8px;
    }

    .border-0-3px-fresh-air {
        border: 0.3px solid var(--fresh-air);
    }

    .border-0-4px-black {
        border: 0.4px solid var(--black);
    }

    .border-0-4px-white {
        border: 0.4px solid var(--white);
    }

    .border-2px-white {
        border: 2px solid var(--white);
    }

    .border-0-5px-white {
        border: 0.5px solid var(--white);
    }

    .border-0-4px-glacier {
        border: 0.4px solid var(--glacier);
    }

    .border-1px-glacier {
        border: 1px solid var(--glacier);
    }

    .border-0-9px-black-3 {
        border: 0.9px solid var(--black-3);
    }

    .border-0-9px-black-4 {
        border: 0.9px solid var(--black-4);
    }
</style>

<script>
    import { mapGetters } from 'vuex'
    import TodoItem from './TodoItem'
    //import Userpage from './Userpage'
    import axios from 'axios'
    import Userfront from "@userfront/core"

    Userfront.init("demo1234");
    export default {
        name: 'SP',
        props: ['title'],

        computed: {
            ...mapGetters(['username']),
            isLoggedOut() {
                return !Userfront.tokens.accessToken;
            },
        },

        components: { TodoItem },

        data() {
            return {
                todos: [],
                pageId: "",
                alltags: [],
                select: '',
            }
        },

        async created() {
            await this.getAllPages();
            await this.get_all_tags();
        },

        methods: {

            async addNewTodo() {

                await axios.post('api/Page/Create', {
                    newName: "Untitled",
                }, {
                    headers: {
                        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                    }
                });
                await this.getAllPages();
            },

            async DeleteTodo(todo) {
                await axios.delete('api/Page/' + todo.id, {
                    headers: {
                        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                    }
                });
                await this.getAllPages();
            },

            handleLogout() {
                console.log('log_out_button'),
                    Userfront.logout();
                console.log('log_out_button2'),
                    this.$router.push('/');

            },

            async getAllPages() {
                const response = await axios.get('api/Page/GetAll', {
                    headers: {
                        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                    }
                });
                this.todos = response.data;
            },

            QuestionPage() {
                this.$router.push('/question');
            },

            async getUntagged()  {
                const response = await axios.get('api/Page/GetPageUntagged', {
                    headers: {
                        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                    }
                });
                this.todos = response.data;
            },

            async getPagesTag(tag) {
                const response = await axios.get('api/Page/GetPageTag?tag=' + tag, {
                    headers: {
                        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                    }
                });
                this.todos = response.data;
            },

            async getPageLast(n) {
                const response = await axios.get('api/Page/GetPageLast?countLast=' + n, {
                    headers: {
                        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                    }
                });
                this.todos = response.data;
            },

            async get_all_tags() {

                const response = await axios.get('api/Page/GetTag', {
                    headers: {
                        'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                    }
                });
                this.alltags = response.data;
            },
        }
    }
</script>
