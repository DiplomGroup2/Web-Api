<template>
    <input type="hidden" id="anPageName" name="page" value="desktop-2" />
    <div class="container-center-horizontal">
        <div class="desktop-2 screen">
            <form @submit.prevent="handleSubmit">
                <div class="overlap-group4">
                    <div class="rectangle-2 border-0-2px-gray"></div>
                    <div class="overlap-group1">
                        <div class="rectangle-3"></div>
                        <div class="overlap-group">
                            <img class="ellipse-1"
                                 src="../assets/ellipse-1-2@2x.svg" />
                            <img class="ellipse-2"
                                 src="../assets/ellipse-2-2@2x.svg" />
                            <img class="ellipse-3"
                                 src="../assets/ellipse-3-2@2x.svg" />
                            <img class="ellipse-4"
                                 src="../assets/ellipse-4-9@2x.svg" />
                            <img class="ellipse-5"
                                 src="../assets/ellipse-5-2@2x.svg" />
                            <img class="vector"
                                 src="../assets/vector-12@2x.svg" />
                            <img class="vector-1"
                                 src="../assets/vector-13@2x.svg" />
                            <img class="vector-2"
                                 src="../assets/vector-14@2x.svg" />
                        </div>
                        <div class="ellipse-6"></div>
                        <div class="ellipse-7"></div>
                    </div>
                    <!--<div class="rectangle-12 border-0-4px-black">-->
                    <input type="email" class="form-control rectangle-12 border-0-4px-black" v-model="email" placeholder="Email" />


                    <!--</div>-->
                    <!--<div class="rectangle-13 border-0-4px-black">-->
                    <input type="password" class="form-control rectangle-13 border-0-4px-black" v-model="password" placeholder="Password" />

                    <!--</div>-->
                    <!--<div class="rectangle-14 border-0-4px-black">-->
                    <input type="password" class="form-control rectangle-14 border-0-4px-black" v-model="password_confirm" placeholder="Repeat password" />

                    <!--</div>-->
                    <div class="create-account fredoka-medium-black-30px">Create Account</div>
                    <p class="dont-have-an-accoun fredoka-light-black-16px">
                        Don&#39;t have an account yet?<br />You must register otherwise your data will be lost.
                    </p>
                    <div class="group-8 border-0-4px-white">
                        <div class="overlap-group-container">
                            <img :src="require('@/assets/Plus.jpg')"/>
                        </div>
                    </div>
                    <!--<div class="place fredoka-light-nobel-16px">Name</div>
    <div class="email fredoka-light-nobel-16px">Email</div>
    <div class="password fredoka-light-nobel-16px">Password</div>-->
                    <div class="group-67">
                        <img class="vector-5"
                             src="../assets/vector-5-1@2x.svg" />
                    </div>
                    <div class="rectangle-69"></div>
                    <button class="btn btn-primary btn-block ">
                        <div class="place-1 fredoka-normal-white-20px">
                            Sign Up
                            <!--Register-->
                        </div>
                    </button>
                    <h1 class="title fredoka-bold-white-36px">Welcome!</h1>
                    <p class="we-provide-you-with fredoka-light-white-16px">
                        We provide you with a world of infinitely convenient notes. Make up your tasks for the day, a list of
                        products or a plan for working with a team in a couple of clicks!
                    </p>
                    <div class="overlap-group3 border-0-4px-white">
                        <div class="sing-in fredoka-normal-white-20px" @click="FromRegisterIntoSignIn" >Sign in</div>
                    </div>
                    <error v-if="error" :error="error" />

                </div>
            </form>
        </div>
    </div>

    <div>
        <!--<form @submit.prevent="handleSubmit">
        <error v-if="error" :error="error"/>-->
        <!--<h3>Sign Up</h3>-->
        <!--<div class="form-group">
            <label>First Name</label>
            <input type="text" class="form-control" v-model="first_name"  placeholder="First Name"/>
            </div>
            <div class="form-group">
            <label>Last Name</label>
            <input type="text" class="form-control" v-model="last_name" placeholder="Last Name"/>
            </div>-->
        <!--<div class="form-group">
        <label>Email</label>-->
        <!--<input type="email" class="form-control" v-model="login" placeholder="Email"/>-->
        <!--</div>-->
<!--
        <div class="form-group">
            <label>Password</label>
            <input type="password" class="form-control" v-model="password" placeholder="Password" />
        </div>-->

        <!-- <div class="form-group">
        <label>Confirm Password</label>
        <input type="password" class="form-control" v-model="password_confirm" placeholder="Confirm Password"/>
        </div>-->
        <!--<button class="btn btn-primary btn-block">Sign Up</button>-->
        <!--</form>-->
    </div>
</template>

<script>
    import axios from 'axios'
    import Error from './Error.vue'
    //import Login from './Login';

    export default {
        name: 'REGISTER',
        components: {
            Error
        },
        data() {
            return {
                //first_name:'',
                //last_name:'',
                email: '',
                password: '',
                password_confirm: '',
                error: ''
            }
        },
        methods: {
            async handleSubmit() {
                try {
                    if (this.password != this.password_confirm) {
                        this.error = 'Passwords do not match';
                        return;
                    }
                    console.log('submitted'),
                        await axios.post('api/Account/Register', {
                            //first_name:this.first_name,
                            //last_name:this.last_name,
                            email: this.email,
                            password: this.password,
                            //assword_confirm:this.password_confirm
                        });

                    this.$router.push('/login');
                } catch (e) {
                    this.error = 'Error occurred!';
                }
                
            },
            FromRegisterIntoSignIn(){
                    this.$router.push('/login');

                }

        }
        //СТИЛИ,КОТОРЫЕ БЫЛИ
       // .desktop-2 {
       // align-items: flex-start;
        //background-color: var(--baby-powder);
        //display: flex;
       // height: 1024px;
        //padding: 100px 400px;
        //width: 1440px;
    //}
    }
</script>

<style>
    .desktop-2 {
        
         background-color:#e3e8ee;
        /*margin-left: 180px;
        margin-top:50px; 
        height: 10px;
        width: 100px;СТИЛЬ С ЗЕЛЕНЫМ ФОНОМ*/
        height: 969px;/*ПЕРЕДЕЛКА*/
        width: 1918px;/*ПЕРЕДЕЛКА*/
         
    }

    .desktop-2 .overlap-group4 {
        height: 655px;
        position: relative;
        width: 1119px;
        margin-left:380px;/*добавлено*/
        margin-top:120px;/*добавлено*/
        
    }

    .desktop-2 .rectangle-2 {
        background-color: var(--white);
        border-radius: 12px;
        box-shadow: 0px 7px 10px #00000040;
        height: 655px;
        left: 69px;
        position: absolute;
        top: 0;
        width: 1051px;
    }

    .desktop-2 .overlap-group1 {
        height: 655px;
        left: 0;
        position: absolute;
        top: 0;
        width: 688px;
    }

    .desktop-2 .rectangle-3 {
        /* Изменение в стиле фона*/
        background: linear-gradient(180deg, #74FDE0, #5BBCFD);
        border-radius: 12px 0px 0px 12px;
        height: 655px;
        left: 66px;
        position: absolute;
        top: 0;
        width: 533px;
    }

    .desktop-2 .overlap-group {
        height: 226px;
        left: 429px;
        position: absolute;
        top: 397px;
        width: 259px;
    }

    .desktop-2 .ellipse-1 {
        height: 223px;
        left: 0;
        position: absolute;
        top: 0;
        width: 259px;
    }

    .desktop-2 .ellipse-2 {
        height: 148px;
        left: 30px;
        position: absolute;
        top: 8px;
        width: 221px;
    }

    .desktop-2 .ellipse-3 {
        height: 203px;
        left: 31px;
        position: absolute;
        top: 23px;
        width: 203px;
    }

    .desktop-2 .ellipse-4 {
        height: 113px;
        left: 76px;
        position: absolute;
        top: 73px;
        width: 113px;
    }

    .desktop-2 .ellipse-5 {
        height: 167px;
        left: 49px;
        position: absolute;
        top: 45px;
        width: 161px;
    }

    .desktop-2 .vector {
        height: 27px;
        left: 103px;
        position: absolute;
        top: 100px;
        width: 29px;
    }

    .desktop-2 .vector-1 {
        height: 24px;
        left: 135px;
        position: absolute;
        top: 125px;
        width: 26px;
    }

    .desktop-2 .vector-2 {
        height: 42px;
        left: 116px;
        position: absolute;
        top: 104px;
        width: 37px;
    }

    .desktop-2 .ellipse-6 {
        -webkit-backdrop-filter: blur(10px) brightness(100%);
        backdrop-filter: blur(10px) brightness(100%);
        background: linear-gradient(180deg, rgb(255, 255, 255) 0%, rgba(255, 255, 255, 0) 100%);
        border-radius: 79.58px;
        box-shadow: 0px 4px 4px #eafffac2;
        height: 159px;
        left: 23px;
        position: absolute;
        top: 23px;
        transform: rotate(-159.22deg);
        width: 159px;
    }

    .desktop-2 .ellipse-7 {
        -webkit-backdrop-filter: blur(10px) brightness(100%);
        backdrop-filter: blur(10px) brightness(100%);
        background: linear-gradient(180deg, rgb(255, 255, 255) 0%, rgba(255, 255, 255, 0) 100%);
        border-radius: 50.34px;
        box-shadow: 0px 4px 4px #eafffac2;
        height: 101px;
        left: 17px;
        position: absolute;
        top: 107px;
        transform: rotate(-75.00deg);
        width: 101px;
    }

    .desktop-2 .rectangle-12 {
        -webkit-backdrop-filter: blur(15px) brightness(100%);
        backdrop-filter: blur(15px) brightness(100%);
        background-color: var(--white-32);
        border-radius: 13px;
        height: 48px;
        left: 700px;
        position: absolute;
        top: 259px;
        width: 313px;
    }

    .desktop-2 .rectangle-13 {
        -webkit-backdrop-filter: blur(15px) brightness(100%);
        backdrop-filter: blur(15px) brightness(100%);
        background-color: var(--white-32);
        border-radius: 13px;
        height: 48px;
        left: 700px;
        position: absolute;
        top: 328px;
        width: 313px;
    }

    .desktop-2 .rectangle-14 {
        -webkit-backdrop-filter: blur(15px) brightness(100%);
        backdrop-filter: blur(15px) brightness(100%);
        background-color: var(--white-32);
        border-radius: 13px;
        height: 48px;
        left: 700px;
        position: absolute;
        top: 396px;
        width: 313px;
    }

    .desktop-2 .create-account {
        left: 750px;
        letter-spacing: 0;
        position: absolute;
        text-align: center;
        top: 116px;
        width: 222px;
    }

    .desktop-2 .dont-have-an-accoun {
        left: 718px;
        letter-spacing: 0;
        position: absolute;
        text-align: center;
        top: 170px;
        width: 277px;
    }

    .desktop-2 .group-8 {
        align-items: flex-end;
        background: white;
        border-radius: 32px;
        display: flex;
        height: 50px;
        justify-content: flex-end;
        left: 820px;
        min-width: 59px;
        padding: 8.2px 5.6px;
        position: absolute;
        top: 52px;
    }

    .desktop-2 .overlap-group-container {
        height: 50px;
        position: relative;
        width: 46px;
    }

    .desktop-2 .overlap-group-1 {
        height: 35px;
        left: 11px;
        position: absolute;
        top: 7px;
        width: 35px;
    }

    .desktop-2 .rectangle-14-1 {
        background: linear-gradient(180deg, rgb(102, 138, 254) 0%, rgb(157, 219, 252) 36.98%, rgb(225, 241, 253) 100%);
        border-radius: 10px;
        height: 35px;
        left: 14px;
        position: absolute;
        top: 0;
        transform: rotate(-90.00deg);
        width: 7px;
    }

    .desktop-2 .rectangle-15 {
        background: linear-gradient(180deg, rgb(102, 138, 254) 0%, rgb(157, 219, 252) 36.98%, rgb(225, 241, 253) 100%);
        border-radius: 10px;
        height: 35px;
        left: 14px;
        position: absolute;
        top: 0;
        transform: rotate(-180deg);
        width: 7px;
    }

    .desktop-2 .rectangle-16 {
        background: linear-gradient(180deg, rgb(102, 138, 254) 0%, rgb(157, 219, 252) 36.98%, rgb(225, 241, 253) 100%);
        height: 5px;
        left: 14px;
        position: absolute;
        top: 15px;
        width: 7px;
    }

    .desktop-2 .overlap-group1-1 {
        height: 43px;
        left: 0;
        position: absolute;
        top: 0;
        width: 43px;
    }

    .desktop-2 .rectangle-14-2 {
        background-color: var(--white-10);
        border-radius: 10px;
        height: 43px;
        left: 17px;
        position: absolute;
        top: 0;
        transform: rotate(-90.00deg);
        width: 8px;
    }

    .desktop-2 .rectangle-15-1 {
        background-color: var(--white-10);
        border-radius: 10px;
        height: 43px;
        left: 17px;
        position: absolute;
        top: 0;
        transform: rotate(-180deg);
        width: 8px;
    }

    .desktop-2 .place {
        left: 718px;
        letter-spacing: 0;
        position: absolute;
        top: 271px;
    }

    .desktop-2 .email {
        left: 718px;
        letter-spacing: 0;
        position: absolute;
        top: 341px;
    }

    .desktop-2 .password {
        left: 718px;
        letter-spacing: 0;
        position: absolute;
        top: 410px;
    }

    .desktop-2 .group-67 {
        align-items: flex-end;
        background-color: var(--white);
        display: flex;
        height: 28px;
        justify-content: flex-end;
        left: 972px;
        min-width: 32px;
        padding: 6.8px 5.7px;
        position: absolute;
        top: 407px;
    }

    .desktop-2 .vector-5 {
        height: 10px;
        width: 21px;
    }

    .desktop-2 .rectangle-69 {
        background-color: var(--malibu);
        border-radius: 20px;
        height: 38px;
        left: 788px;
        position: absolute;
        top: 472px;
        width: 138px;
    }

    .desktop-2 .place-1 {
        left: 819px;
        letter-spacing: 0;
        position: absolute;
        top: 477px;
    }

    .desktop-2 .title {
        left: 256px;
        letter-spacing: 0;
        position: absolute;
        top: 179px;
    }

    .desktop-2 .we-provide-you-with {
        left: 139px;
        letter-spacing: 0;
        position: absolute;
        text-align: center;
        top: 255px;
        width: 387px;
    }

    .desktop-2 .overlap-group3 {
        -webkit-backdrop-filter: blur(4px) brightness(100%);
        align-items: flex-start;
        backdrop-filter: blur(4px) brightness(100%);
        background-color: var(--white-7);
        border-radius: 20px;
        display: flex;
        height: 38px;
        left: 264px;
        min-width: 138px;
        padding: 4.9px 39.2px;
        position: absolute;
        top: 358px;
    }

    .desktop-2 .sing-in {
        letter-spacing: 0;
        min-height: 24px;
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
        --baby-powder: #fcfcfc;
        --black: #000000;
        --gray: #919191;
        --malibu: #79a8f9;
        --nobel: #b5b5b5;
        --white: #ffffff;
        --white-10: #ffffff87;
        --white-32: #ffffff3b;
        --white-7: #ffffff33;
        --font-size-l: 20px;
        --font-size-m: 16px;
        --font-size-xxl: 36px;
        --font-size-xxl2: 30px;
        --font-family-fredoka: "Fredoka", Helvetica;
    }

    .fredoka-light-nobel-16px {
        color: var(--nobel);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-m);
        font-style: normal;
        font-weight: 300;
    }

    .fredoka-normal-white-20px {
        color: var(--white);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-l);
        font-style: normal;
        font-weight: 400;
        cursor:pointer;
    }

    .fredoka-medium-black-30px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xxl2);
        font-style: normal;
        font-weight: 500;
    }

    .fredoka-light-black-16px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-m);
        font-style: normal;
        font-weight: 300;
    }

    .fredoka-bold-white-36px {
        color: var(--white);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xxl);
        font-style: normal;
        font-weight: 700;
    }

    .fredoka-light-white-16px {
        color: var(--white);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-m);
        font-style: normal;
        font-weight: 300;
    }

    .border-0-4px-white {
        border: 0.4px solid var(--white);
    }

    .border-0-4px-black {
        border: 0.4px solid var(--black);
    }

    .border-0-2px-gray {
        border: 0.2px solid var(--gray);
    }


    body {
        background: #9df91c;
        min-height: 100vh;
        display: flex;
        font-weight: 400;
        font-family: 'Fira Sans', sand-serif;
    }
</style>