<template>
    <input type="hidden" id="anPageName" name="page" value="9_644" />
    <div class="view">
        <div class="overlap-group3 border-0-4px-black">
            <Userpage v-bind:title="this.title" v-bind:addnew="this.addnew"></Userpage><!--перенос-->
            <div class="flex-row">
                <div class="untitled fredoka-medium-black-17px">Untitled</div>
                <!--<div class="untitled fredoka-medium-black-17px"> {{ title }}</div>-->
                <div class="overlap-group4 border-0-4px-black">
                    <div class="group-134">
                        <v-select
                                  :options="groups"
                                  label="tag">

                        </v-select>
                    </div>
                </div>
                <img class="mask-group" src="../assets/mask-group-4@2x.svg"
                     @click="$emit('remove')" v-if="!addnew" />
            </div>
            <div class="flex-row-1">
                <div class="date">{{createdPage}}</div>
                <img class="vector-8" src="../assets/vector-8@2x.svg" />
                <div class="movies fredoka-light-gray-12px">#movies</div>
            </div>

            <div class="text fredoka-light-black-15px">
                {{ records }}

                <component v-bind:is="component"></component>
                <textarea id="textArea" v-model="message" placeholder="Text.." v-on:blur="save_record">

          </textarea>

            </div>
            <div class="group-container">


                <img class="mask-group-1" src="../assets/mask-group-3@2x.svg" />
                <div class="group-133">
                    <div class="overlap-group1">
                        <div class="overlap-group">
                            <div class="rectangle-39 border-0-9px-black-3"></div>
                            <div class="rectangle-37 border-0-9px-black-4"></div>
                        </div>
                        <img class="line-5" src="../assets/line-5@2x.svg" />
                        <img class="line-6" src="../assets/line-6@2x.svg" />
                    </div>
                </div>
                <div class="group-132">
                    <div class="overlap-group2">
                        <img click="SaveInFile"
                             class="arrow-1" id="arrow" src="../assets/arrow-1@2x.svg" />
                        <img class="ellipse-42" src="../assets/arrow-1@2x.svg" />
                    </div>
                </div>
            </div>

        </div>
    </div>
</template>


<script>

    import Userpage from "./Userpage"
    import axios from 'axios'
    import vSelect from 'vue-select'
    import 'vue-select/dist/vue-select.css';

    export default {
        name: 'TODOITEM',
        props: ['title', 'records', 'createdPage', 'pageId'],
        data() {
            return {
                message: '',
                groups: [],
            }
        },
        emits: ['remove'],
        async created() {
            //Vue.component('v-select', vSelect)
            const response = await axios.get('api/Page/GetTag', {
                headers: {
                    'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                }
            });
            console.log(response);
            this.groups = response.data;
            console.log(this.groups);
        },
        methods: {
           
            async save_record() {
                try {
                    await axios.post('api/Record/CreateText',
                        {
                            Text: this.message,
                            PageId: this.pageId,
                        }, {
                        headers: {
                            'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                        }
                    });
                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }

                //alert(
                //    this.message);
            },

            SaveInFile() {
                /*let textArea = document.getElementById('textArea');

                    async function writeFile(fileHandle, contents) {
                      const writable = await fileHandle.createWritable();
                      await writable.write(contents);
                      await writable.close();
                    }

                    let fileHandle;
                    let saveTo;

                    addEventListener('click', async () => {

                      [fileHandle] = await window.showOpenFilePicker();
                      const file = await fileHandle.getFile();
                      const contents = await file.text();
                      textArea.value = contents;
                    });

                    addEventListener('click', async () => {
                    if (typeof saveTo == 'undefined') {
                        saveTo = await window.showSaveFilePicker();
                    }
                     writeFile(saveTo, textArea.value);
                    });     */
                //СПОСОБ ДВА
                /*function saveFileAs() {
               if (promptFilename = prompt("Save file as", "")) {
                var textBlob = new Blob([document.getElementById("canvas-textarea").value], {type:'text/plain'});
                var downloadLink = document.createElement("a");
                downloadLink.download = promptFilename;
                downloadLink.innerHTML = "Download File";
                downloadLink.href = window.URL.createObjectURL(textBlob);
                downloadLink.click();
                delete downloadLink;
                delete textBlob;
                 }
              }

            document.getElementById("arrow").onclick = saveFileAs;

            }*/
                //СПОСОБ  ТРИ

                /*$(function() {
                  $('#arrow').click(function(e) {
                    var data = document.getElementById('textArea').value;
                     data = 'data:application/csv;charset=utf-8,' + encodeURIComponent(data);
                    var el = e.currentTarget;
                    el.href = data;
                    el.target = '_blank';
                    el.download = 'data.csv';
                  });
                });*/
            },
            components:
                { Userpage, vSelect }
        }
    }

</script>






<style scoped>
    textarea {
        width: 200px;
        height: 60px;
        resize: both;
    }

    .view {
        align-items: flex-start;
        /*display: flex;
                                height: 192px;
                                */
        overflow: hidden;
        padding: 0.6px 0;
        /* width: 265px;*/
        min-height: 192px;
        min-width: 265px;
        padding: 10px;
        margin: 10px;
        display: inline-block;
    }

    .overlap-group3 {
        -webkit-backdrop-filter: blur(15px) brightness(100%);
        align-items: flex-start;
        backdrop-filter: blur(15px) brightness(100%);
        background-color: var(--white);
        border-radius: 13px;
        box-shadow: 0px 4px 0px #8aa7de;
        /*display: flex;
    flex-direction: column;
    min-height: 187px;*/
        padding: 14.0px 19.7px;
        width: 265px;
        flex-direction: column;
        /* НИЖЕ ДОБАВЛЕНЫ УВЕЛИЧЕНИЯ ТАЙЛА */
        resize: both;
        display: inline-block;
        overflow: auto;
        min-width: 150px;
        min-height: 150px;
        max-width: 1026px;
        max-height: 750px;
    }

    .flex-row {
        align-items: flex-start;
        align-self: center;
        display: flex;
        height: 21px;
        margin-left: 0.08px;
        min-width: 225px;
    }

    .untitled {
        letter-spacing: 0;
        min-height: 20px;
        width: 68px;
    }

    .overlap-group4 {
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

    .group-134 {
        align-items: flex-end;
        background-color: var(--white);
        display: flex;
        height: 11px;
        min-width: 15px;
        padding: 3.2px 2.7px;
    }

    .vector-9 {
        height: 3px;
        width: 9px;
    }

    .mask-group {
        align-self: center;
        height: 18px;
        margin-left: 17px;
        margin-top: 0.89px;
        width: 18px;
        cursor: pointer;
    }

    .flex-row-1 {
        align-items: flex-end;
        display: flex;
        height: 16px;
        margin-left: 0.4px;
        margin-top: 1px;
        min-width: 98px;
    }

    .date {
        color: var(--gray);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xs);
        font-weight: 300;
        letter-spacing: 0;
        min-height: 14px;
        width: 40px;
    }

    .vector-8 {
        height: 14px;
        margin-bottom: 0.14px;
        margin-left: 10px;
        width: 1px;
    }

    .movies {
        align-self: flex-start;
        letter-spacing: 0;
        min-height: 16px;
        margin-left: 4px;
        width: 49px;
    }

    .text {
        letter-spacing: 0;
        margin-top: 8px;
        min-height: 16px;
        width: 39px;
    }

    .group-container {
        align-items: flex-start;
        display: flex;
        margin-left: 0.88px;
        margin-top: 30px; /* изменено  74px; / 40 px  */
        min-width: 88px;
    }

    .mask-group-1 {
        height: 21px;
        width: 21px;
    }

    .group-133 {
        align-items: flex-start;
        align-self: flex-end;
        display: flex;
        margin-bottom: 0;
        margin-left: 13px;
        min-width: 22px;
        opacity: 0.5;
    }

    .overlap-group1 {
        height: 20px;
        position: relative;
        width: 22px;
    }

    .overlap-group {
        height: 20px;
        left: 0;
        position: absolute;
        top: 0;
        width: 22px;
    }

    .rectangle-39 {
        border-radius: 3.98px;
        height: 15px;
        left: 0;
        position: absolute;
        top: 0;
        width: 15px;
    }

    .rectangle-37 {
        background-color: var(--white);
        border-radius: 5.31px;
        height: 17px;
        left: 5px;
        position: absolute;
        top: 3px;
        width: 17px;
    }

    .line-5 {
        height: 9px;
        left: 13px;
        position: absolute;
        top: 7px;
        width: 1px;
    }

    .line-6 {
        height: 1px;
        left: 9px;
        position: absolute;
        top: 11px;
        width: 9px;
    }

    .group-132 {
        align-items: flex-end;
        display: flex;
        height: 20px;
        margin-left: 13px;
        min-width: 20px;
        opacity: 0.5;
        padding: 0.0px 0.0px;
    }

    .overlap-group2 {
        height: 18px;
        position: relative;
        width: 20px;
    }

    .arrow-1 {
        height: 14px;
        left: 5px;
        position: absolute;
        top: 0;
        width: 10px;
        cursor: pointer;
    }

    .ellipse-42 {
        height: 10px;
        left: 0;
        position: absolute;
        top: 8px;
        width: 20px;
    }

    @import url("https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css");

    @import url("https://fonts.googleapis.com/css?family=Fredoka:400,300,700,500");

    * {
        box-sizing: border-box;
    }

    :root {
        --black: #000000;
        --black-32: #00000091;
        --black-4: #000000cc;
        --gray: #919192;
        --white: #ffffff;
        --font-size-l: 17px;
        --font-size-s: 15px;
        --font-size-xs: 12px;
        --font-size-xxs: 10.4px;
        --font-family-fredoka: "Fredoka", Helvetica;
    }

    .fredoka-medium-black-17px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-l);
        font-style: normal;
        font-weight: 500;
    }

    .fredoka-light-gray-12px {
        color: var(--gray);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-xs);
        font-style: normal;
        font-weight: 300;
        margin-left: 5px;
        margin-top: 2px;
    }

    .fredoka-light-black-15px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-s);
        font-style: normal;
        font-weight: 300;
    }

    .border-0-4px-black {
        border: 0.4px solid var(--black);
    }

    .border-0-9px-black-3 {
        border: 0.9px solid var(--black-32);
    }

    .border-0-9px-black-4 {
        border: 0.9px solid var(--black-4);
    }
</style>

